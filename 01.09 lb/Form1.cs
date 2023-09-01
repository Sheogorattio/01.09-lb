using _01._09_lb.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01._09_lb.Model;

namespace _01._09_lb
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Form";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sex;
            if (MaleRadio.Checked == true) sex = "Male";
            else sex = "Female";
            PersonControl personControl = new PersonControl(new Person(NameTextBox.Text, SurnameTextBox.Text, PatronTextBox.Text, sex , DateTime.Parse( BirthDateTextBox.Text) , MartialTextBox.Text, AddInfoTextBox.Text));
            personControl.SaveInfo();
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            PatronTextBox.Clear();
            MaleRadio.Checked = true;
            BirthDateTextBox.Clear();
            AddInfoTextBox.Clear();
            MartialTextBox.Clear();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            PersonControl personControl = new PersonControl();
            Person obj = personControl.LoadInfo(openFileDialog.FileName);
            if(obj != null)
            {
                NameTextBox.Text = obj.Name;
                SurnameTextBox.Text = obj.Surname;
                PatronTextBox.Text = obj.Patronymic;
                if(obj.Sex == "Male") MaleRadio.Checked = true;
                else FemaleRadio.Checked = true;
                BirthDateTextBox.Text = obj.BirhDate.ToString();
                AddInfoTextBox.Text = obj.PersonalInfo;
                MartialTextBox.Text = obj.MartialSt;
            }
        }
    }
}
