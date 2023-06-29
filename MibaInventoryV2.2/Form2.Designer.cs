using System.ComponentModel;

namespace MibaInventoryV2._2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Array_textBox = new System.Windows.Forms.TextBox();
            this.Count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(138, 158);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(286, 56);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Добавить";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Array_textBox
            // 
            this.Array_textBox.Location = new System.Drawing.Point(48, 108);
            this.Array_textBox.Name = "Array_textBox";
            this.Array_textBox.Size = new System.Drawing.Size(480, 31);
            this.Array_textBox.TabIndex = 6;
            // 
            // Count_numericUpDown
            // 
            this.Count_numericUpDown.Location = new System.Drawing.Point(436, 44);
            this.Count_numericUpDown.Name = "Count_numericUpDown";
            this.Count_numericUpDown.Size = new System.Drawing.Size(92, 31);
            this.Count_numericUpDown.TabIndex = 5;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(48, 43);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(376, 31);
            this.Name_textBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 256);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Array_textBox);
            this.Controls.Add(this.Count_numericUpDown);
            this.Controls.Add(this.Name_textBox);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить элемент";
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox Array_textBox;
        private System.Windows.Forms.NumericUpDown Count_numericUpDown;
        private System.Windows.Forms.TextBox Name_textBox;

        #endregion
    }
}