using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_indexOfArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalCount = 0;
        //string[] name = new string[10];

        List<string> name = new List<string>();
         int sizeOfNameList = 0;

        private void AddButton_Click(object sender, EventArgs e)
        {

            {
                name.Add(nameTextBox.Text);// nameTextBox.Text;

                nameTextBox.Text = "";

                totalCount++;

                if (totalCount >= sizeOfNameList)
                {
                    showNameListBox.Items.Clear();

                    addButton.Enabled = false;

                    GetValue();



                    //addButton.Dispose();
                }


                addCountCounterLabel.Text = totalCount.ToString();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            showNameListBox.Items.Clear();

            GetValue();
        }

        private void GetValue()
        {
            int i = 0;
            for (; i < name.Count; i++)
            {
                if (name[i] != null)
                    showNameListBox.Items.Add((i + 1) + ".  " + name[i]);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

            

            addButton.Enabled = true;
            setButton.Enabled = true;

            showNameListBox.Items.Clear();
            addCountCounterLabel.Text = "0";
            name.Clear();

                totalCount = 0;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            sizeOfNameList = Convert.ToInt32(employeeNumberTextBox.Text);
            
            employeeNumberTextBox.Text = "";
            addButton.Enabled = true;
            resetButton.Enabled = true;
            showAllButton.Enabled = true;
            setButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            resetButton.Enabled = false;
            showAllButton.Enabled = false;
        }

        private void employeeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = false;
        }

        private void AddNameGroupBox_Enter(object sender, EventArgs e)
        {

        }


    }
}
