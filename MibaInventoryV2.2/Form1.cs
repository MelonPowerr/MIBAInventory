using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace MibaInventoryV2._2
{
    public partial class Form1 : Form
    {
        private static string jsonFilePath = "Data.json";
        private static string FilePath = "./logs/";
        List<Merch> SavedData;
        List<Merch> data;
        public class Merch
        {
            public string ItemName { get; set; }
            public List<int> InitCount { get; set; }
            public List<int> FinalCount { get; set; }
        }
        public Merch MerchData { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            start();
        }
        
        //Проверка джсон файла, можно добавить особую папку, c файлами логами тхт
        private void start()
        {
            if (!File.Exists(jsonFilePath))
            {
                File.WriteAllText(jsonFilePath, "[]");
            }
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            list_update();
        }
        
        //добавление элемента в базу
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();
            if (MerchData != null)
            {
                Merch newdata = new Merch
                {
                    ItemName = MerchData.ItemName,
                    InitCount = new List<int>(MerchData.InitCount),
                    FinalCount = new List<int> (MerchData.FinalCount)
                };
                data.Add(newdata);
                string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(jsonFilePath, updatedJson);
                MerchData = null;
            }
            list_update();
        }
        
        
        //Отвечает за удаление элемента из базы
        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nameToRemove = ItemsListBox1.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить строку '{nameToRemove}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    Merch itemToRemove = data.FirstOrDefault(x => x.ItemName == nameToRemove);
                    if (itemToRemove != null)
                    {
                        data.Remove(itemToRemove);
                        File.Delete(FilePath+ItemsListBox1.SelectedItem.ToString()+".txt");
                    }
                    string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, updatedJson);
                    list_update();
                }
                else if (dialogResult == DialogResult.No)
                {
                    list_update();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбран элемент для удаления","Ошибка",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
        
        //Отвечает за вычет из нужной коробки
        //нужно добавить составление тхт файла с логами -- есть
        private void SubBtn_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Merch> data = JsonConvert.DeserializeObject<List<Merch>>(json);

            if (!string.IsNullOrEmpty(textBox1.Text) && ItemsListBox1.SelectedItem != null &&
                SelectionBox.SelectedItem != null && numericUpDown1.Value != 0)
            {
                Merch itemToEdit = data.FirstOrDefault(x => x.ItemName == ItemsListBox1.SelectedItem.ToString());
                int selectedIndex = SelectionBox.SelectedIndex;
                int subtractValue = (int)numericUpDown1.Value;
                
                if (itemToEdit != null && selectedIndex >= 0 && selectedIndex < itemToEdit.FinalCount.Count)
                {
                    if (itemToEdit.FinalCount[selectedIndex] - subtractValue >= 0)
                    {
                        itemToEdit.FinalCount[selectedIndex] -= subtractValue;
                        string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
                        File.WriteAllText(jsonFilePath, updatedJson);
                        
                        txtlog(ItemsListBox1,textBox1,SelectionBox,numericUpDown1);
                        Thread thread = new Thread(ChangeColor);
                        thread.Start();
                        datagridview_update();
                    }
                    else
                    {
                        MessageBox.Show("Вычет слишком большого кол-ва элементов","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Форма не заполнена полностью");
            }
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            string path = FilePath + ItemsListBox1.SelectedItem + ".txt";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Кому; Номер коробки; Сколько\n");
            }
            Process.Start("notepad.exe", path);
        }
        private void txtlog(ListBox listBox, TextBox textBox, ComboBox comboBox, NumericUpDown numericUpDown)
        {
            string logFilePath = FilePath + listBox.SelectedItem + ".txt";
            if (!File.Exists(logFilePath))
            {
                File.WriteAllText(logFilePath, "Кому; Номер коробки; Сколько\n");
            }
            File.AppendAllText(logFilePath, textBox.Text + "; " + comboBox.SelectedItem + "; " + numericUpDown.Value + Environment.NewLine);
        }
        
        private void ChangeColor()
        {
            RemainingLbl.Invoke((MethodInvoker)(() => RemainingLbl.ForeColor = System.Drawing.Color.Red));
            
            Thread.Sleep(500);
            
            RemainingLbl.Invoke((MethodInvoker)(() => RemainingLbl.ForeColor = System.Drawing.SystemColors.ControlText));
        }
        
        //Отвечает за очистку текстбокса
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        
        
        //Отвечает за обновление списка предметов
        private void list_update()
        {
            ItemsListBox1.Items.Clear();
            
            string json = File.ReadAllText(jsonFilePath);

            if (!string.IsNullOrEmpty(json))
            {
                data = JsonConvert.DeserializeObject<List<Merch>>(json);
            }
            else
            { 
                data = new List<Merch>();
            }

            foreach (Merch item in data)
            {
                ItemsListBox1.Items.Add(item.ItemName);
            }
        }
        
        
        //Отвечает за обновление таблицы + счетчика остатка
        private void datagridview_update()
        {
            string json = File.ReadAllText(jsonFilePath);
            data = JsonConvert.DeserializeObject<List<Merch>>(json);
            
            int initValueSum = 0;
            int finalValueSum = 0;

            SelectionBox.Items.Clear();
            string selectedName = ItemsListBox1.SelectedItem.ToString();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Номер коробки", typeof(string));
            dataTable.Columns.Add("Изначальное", typeof(string));
            dataTable.Columns.Add("Нынешнее", typeof(string));

            foreach (Merch item in data)
            {
                if (item.ItemName == selectedName)
                {
                    for (int i = 0; i < item.InitCount.Count; i++)
                    {
                        string number = (i + 1).ToString();
                        string initValue = item.InitCount[i].ToString();
                        string finalValue = item.FinalCount[i].ToString();
                        dataTable.Rows.Add(number, initValue, finalValue);
                        SelectionBox.Items.Add(number);
                        initValueSum += item.InitCount[i];
                        finalValueSum += item.FinalCount[i];
                    }
                }
            }
            TotalLbl.Text = "Всего: " + initValueSum;
            RemainingLbl.Text = "Осталось: " + finalValueSum;
            dataGridView1.DataSource = dataTable;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
        
        private void ItemsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                datagridview_update();
            }
            catch (System.NullReferenceException)
            {
            }
        }

        private void AddBoxBtn_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Merch> data = JsonConvert.DeserializeObject<List<Merch>>(json);
            Merch itemToUpdate = data.FirstOrDefault(x => x.ItemName == ItemsListBox1.SelectedItem.ToString());
            if (itemToUpdate != null)
            {
                itemToUpdate.InitCount.Add(0);
                itemToUpdate.FinalCount.Add(0);
                
                string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
                
                File.WriteAllText(jsonFilePath, updatedJson);
            }
            datagridview_update();
        }

        private void turnOffOn(bool x)
        {
            AddBoxBtn.Visible = x;
            CancelAddBtn.Visible = x;
            SaveBtn.Visible = x;
            DelBoxBtn.Visible = x;
            SettingsBtn.Visible = !x;
        }
        private void CancelAddBtn_Click(object sender, EventArgs e)
        {
            string savedJson = JsonConvert.SerializeObject(SavedData, Formatting.Indented);
            File.WriteAllText(jsonFilePath, savedJson);
            turnOffOn(false);
            datagridview_update();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (ItemsListBox1.SelectedItem != null)
            {
                string json = File.ReadAllText(jsonFilePath);
                SavedData = JsonConvert.DeserializeObject<List<Merch>>(json);
                turnOffOn(true);
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите сохранить изменения?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string json = File.ReadAllText(jsonFilePath);
                List<Merch> data = JsonConvert.DeserializeObject<List<Merch>>(json);
                
                Merch itemToRemove = data.FirstOrDefault(x => x.ItemName == ItemsListBox1.SelectedItem.ToString());
                if (itemToRemove != null)
                {
                    data.Remove(itemToRemove);
                }
                string itemName = ItemsListBox1.SelectedItem.ToString();
                List<int> initCount = new List<int>();
                List<int> finalCount = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    initCount.Add(Convert.ToInt32(row.Cells["Изначальное"].Value));
                    finalCount.Add(Convert.ToInt32(row.Cells["Нынешнее"].Value));
                }
                Merch merch = new Merch
                {
                    ItemName = itemName,
                    InitCount = initCount,
                    FinalCount = finalCount
                };
                //оно почему-то сохранят+1 нулевую строку, мне уже лень искать решение, соу после изменения вычитаю одну строку
                merch.InitCount.RemoveAt(merch.InitCount.Count-1);
                merch.FinalCount.RemoveAt(merch.FinalCount.Count-1);
                data.Add(merch);
                string conv = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(jsonFilePath, conv);
                datagridview_update();
                turnOffOn(false);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        
        
        private void DelBoxBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Вы уверены что хотите удалить последнюю строку?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string json = File.ReadAllText(jsonFilePath);
                    List<Merch> data = JsonConvert.DeserializeObject<List<Merch>>(json);
                    Merch merch = data.FirstOrDefault(x => x.ItemName == ItemsListBox1.SelectedItem.ToString());

                    if (merch.InitCount.Count > 0)
                    {
                        merch.InitCount.RemoveAt(merch.InitCount.Count - 1);
                        merch.FinalCount.RemoveAt(merch.FinalCount.Count - 1);

                        string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);

                        File.WriteAllText(jsonFilePath, updatedJson);
                    }

                    datagridview_update();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Нельзя удалить первую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}