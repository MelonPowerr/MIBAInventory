namespace MibaInventoryV2._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubGroupBox = new System.Windows.Forms.GroupBox();
            this.LogBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RemainingLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.SubBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemsListBox1 = new System.Windows.Forms.ListBox();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBoxBtn = new System.Windows.Forms.Button();
            this.CancelAddBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DelBoxBtn = new System.Windows.Forms.Button();
            this.SubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubGroupBox
            // 
            this.SubGroupBox.Controls.Add(this.LogBtn);
            this.SubGroupBox.Controls.Add(this.button1);
            this.SubGroupBox.Controls.Add(this.RemainingLbl);
            this.SubGroupBox.Controls.Add(this.TotalLbl);
            this.SubGroupBox.Controls.Add(this.SubBtn);
            this.SubGroupBox.Controls.Add(this.numericUpDown1);
            this.SubGroupBox.Controls.Add(this.SelectionBox);
            this.SubGroupBox.Controls.Add(this.textBox1);
            this.SubGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubGroupBox.Location = new System.Drawing.Point(10, 359);
            this.SubGroupBox.Name = "SubGroupBox";
            this.SubGroupBox.Size = new System.Drawing.Size(503, 467);
            this.SubGroupBox.TabIndex = 12;
            this.SubGroupBox.TabStop = false;
            this.SubGroupBox.Text = "Вычет";
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(15, 398);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(163, 63);
            this.LogBtn.TabIndex = 13;
            this.LogBtn.Text = "Логи";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "✕";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemainingLbl
            // 
            this.RemainingLbl.BackColor = System.Drawing.SystemColors.Control;
            this.RemainingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLbl.Location = new System.Drawing.Point(15, 145);
            this.RemainingLbl.Name = "RemainingLbl";
            this.RemainingLbl.Size = new System.Drawing.Size(469, 70);
            this.RemainingLbl.TabIndex = 5;
            this.RemainingLbl.Text = "Осталось: ";
            // 
            // TotalLbl
            // 
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(15, 55);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(469, 70);
            this.TotalLbl.TabIndex = 4;
            this.TotalLbl.Text = "Всего: ";
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(349, 289);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(145, 47);
            this.SubBtn.TabIndex = 3;
            this.SubBtn.Text = "Вычет";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(226, 295);
            this.numericUpDown1.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericUpDown1.Minimum = new decimal(new int[] { 30, 0, 0, -2147483648 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 38);
            this.numericUpDown1.TabIndex = 1;
            // 
            // SelectionBox
            // 
            this.SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectionBox.Location = new System.Drawing.Point(15, 295);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(205, 39);
            this.SelectionBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 38);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemsListBox1);
            this.groupBox1.Controls.Add(this.DeleteItemBtn);
            this.groupBox1.Controls.Add(this.AddItemBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 322);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ItemsListBox1
            // 
            this.ItemsListBox1.FormattingEnabled = true;
            this.ItemsListBox1.ItemHeight = 25;
            this.ItemsListBox1.Location = new System.Drawing.Point(52, 30);
            this.ItemsListBox1.Name = "ItemsListBox1";
            this.ItemsListBox1.Size = new System.Drawing.Size(433, 279);
            this.ItemsListBox1.TabIndex = 3;
            this.ItemsListBox1.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox1_SelectedIndexChanged);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Location = new System.Drawing.Point(6, 76);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(40, 40);
            this.DeleteItemBtn.TabIndex = 2;
            this.DeleteItemBtn.Text = "-";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(6, 30);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(40, 40);
            this.AddItemBtn.TabIndex = 1;
            this.AddItemBtn.Text = "+";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(540, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(844, 772);
            this.dataGridView1.TabIndex = 10;
            // 
            // AddBoxBtn
            // 
            this.AddBoxBtn.Location = new System.Drawing.Point(540, 800);
            this.AddBoxBtn.Name = "AddBoxBtn";
            this.AddBoxBtn.Size = new System.Drawing.Size(206, 40);
            this.AddBoxBtn.TabIndex = 4;
            this.AddBoxBtn.Text = "Добавить строку";
            this.AddBoxBtn.UseVisualStyleBackColor = true;
            this.AddBoxBtn.Visible = false;
            this.AddBoxBtn.Click += new System.EventHandler(this.AddBoxBtn_Click);
            // 
            // CancelAddBtn
            // 
            this.CancelAddBtn.Location = new System.Drawing.Point(1234, 800);
            this.CancelAddBtn.Name = "CancelAddBtn";
            this.CancelAddBtn.Size = new System.Drawing.Size(150, 40);
            this.CancelAddBtn.TabIndex = 13;
            this.CancelAddBtn.Text = "Отмена";
            this.CancelAddBtn.UseVisualStyleBackColor = true;
            this.CancelAddBtn.Visible = false;
            this.CancelAddBtn.Click += new System.EventHandler(this.CancelAddBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(1234, 800);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(150, 40);
            this.SettingsBtn.TabIndex = 14;
            this.SettingsBtn.Text = "Настройки";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1082, 800);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(146, 40);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DelBoxBtn
            // 
            this.DelBoxBtn.Location = new System.Drawing.Point(752, 800);
            this.DelBoxBtn.Name = "DelBoxBtn";
            this.DelBoxBtn.Size = new System.Drawing.Size(206, 40);
            this.DelBoxBtn.TabIndex = 16;
            this.DelBoxBtn.Text = "Удалить строку";
            this.DelBoxBtn.UseVisualStyleBackColor = true;
            this.DelBoxBtn.Visible = false;
            this.DelBoxBtn.Click += new System.EventHandler(this.DelBoxBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 860);
            this.Controls.Add(this.DelBoxBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.CancelAddBtn);
            this.Controls.Add(this.AddBoxBtn);
            this.Controls.Add(this.SubGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Инвентаризация";
            this.SubGroupBox.ResumeLayout(false);
            this.SubGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button DelBoxBtn;

        private System.Windows.Forms.Button SaveBtn;

        private System.Windows.Forms.Button SettingsBtn;

        private System.Windows.Forms.Button AddBoxBtn;

        private System.Windows.Forms.Button CancelAddBtn;

        private System.Windows.Forms.Button LogBtn;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox SubGroupBox;
        private System.Windows.Forms.Label RemainingLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ItemsListBox1;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}