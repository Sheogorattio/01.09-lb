namespace _01._09_lb
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddInfoTextBox = new System.Windows.Forms.TextBox();
            this.MartialTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.PatronTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(398, 270);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 23;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(195, 270);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Additional info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marital status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Patronymic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // AddInfoTextBox
            // 
            this.AddInfoTextBox.Location = new System.Drawing.Point(289, 233);
            this.AddInfoTextBox.Name = "AddInfoTextBox";
            this.AddInfoTextBox.Size = new System.Drawing.Size(184, 22);
            this.AddInfoTextBox.TabIndex = 14;
            // 
            // MartialTextBox
            // 
            this.MartialTextBox.Location = new System.Drawing.Point(289, 205);
            this.MartialTextBox.Name = "MartialTextBox";
            this.MartialTextBox.Size = new System.Drawing.Size(184, 22);
            this.MartialTextBox.TabIndex = 13;
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.Location = new System.Drawing.Point(289, 176);
            this.BirthDateTextBox.Mask = "00/00/0000";
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.Size = new System.Drawing.Size(184, 22);
            this.BirthDateTextBox.TabIndex = 12;
            this.BirthDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Location = new System.Drawing.Point(370, 149);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(74, 20);
            this.FemaleRadio.TabIndex = 11;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Checked = true;
            this.MaleRadio.Location = new System.Drawing.Point(289, 149);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(58, 20);
            this.MaleRadio.TabIndex = 10;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // PatronTextBox
            // 
            this.PatronTextBox.Location = new System.Drawing.Point(289, 121);
            this.PatronTextBox.Name = "PatronTextBox";
            this.PatronTextBox.Size = new System.Drawing.Size(184, 22);
            this.PatronTextBox.TabIndex = 8;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(289, 93);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(184, 22);
            this.SurnameTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(289, 65);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddInfoTextBox);
            this.Controls.Add(this.MartialTextBox);
            this.Controls.Add(this.BirthDateTextBox);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.PatronTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AddInfoTextBox;
        public System.Windows.Forms.TextBox MartialTextBox;
        public System.Windows.Forms.MaskedTextBox BirthDateTextBox;
        public System.Windows.Forms.RadioButton FemaleRadio;
        public System.Windows.Forms.RadioButton MaleRadio;
        public System.Windows.Forms.TextBox PatronTextBox;
        public System.Windows.Forms.TextBox SurnameTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
    }
}

