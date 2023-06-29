using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MibaInventoryV2._2
{
    public partial class Form2 : Form
    {
        private Form1 newform = new Form1();
        
        private bool CheckNameInJson(string name)
        {
            //хорошо бы сюда перекидывать переменную из формы1
            string jsonFilePath = "Data.json";
            
            string jsonContent = File.ReadAllText(jsonFilePath);
            
            List<Form1.Merch> merchList = JsonConvert.DeserializeObject<List<Form1.Merch>>(jsonContent);
            
            return merchList.Any(merch => merch.ItemName == name);
        }
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            newform = parentForm;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (CheckNameInJson(Name_textBox.Text))
            {
                MessageBox.Show("Такой предмет уже есть в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = Array_textBox.Text;
            input = input.Replace("б", ",");
            input = string.Concat(input.Split(' '));
            if (input.EndsWith(","))
            {
                input = input.TrimEnd(',');
            }
            string[] array = input.Split(',');
            int x = Int32.Parse(Count_numericUpDown.Text);
            if (array.Length != x)
            {
                MessageBox.Show("Кол-во значений и коробок не совпадает","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var converted_array = Array.ConvertAll(array, int.Parse);
                Form1.Merch merchData = new Form1.Merch
                {
                    ItemName = Name_textBox.Text,
                    InitCount = new List<int> (converted_array),
                    FinalCount = new List<int> (converted_array) 
                };
                newform.MerchData = merchData;
                this.Close();
            }
        }
    }
}