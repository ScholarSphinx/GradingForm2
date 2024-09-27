using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing1
{
    public partial class Form1 : Form
    {
        private List<double> marks = new List<double>();

        private double average;
        private double highestMark;
        private string gradeSymbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming there's a TextBox named 'marksTextBox' where the user enters marks
                double mark = double.Parse(marksTextBox.Text); 
                marks.Add(mark); // Add mark to the list

                // Assuming there's a ListBox named 'marksListBox' to display the entered marks
                marksListBox.Items.Add(mark);

                marksTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (marks.Count == 0)
            {
                MessageBox.Show("No marks have been entered.");
                return;
            }

            try
            {

                average = marks.Average();
                highestMark = marks.Max();
                gradeSymbol = GetGradeSymbol(average);

                MessageBox.Show("Marks processed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private string GetGradeSymbol(double average)
        {
            switch (average)
            {
                case var n when (n >= 75):
                    return "A";
                case var n when (n >= 70 && n < 75):  
                    return "B";
                case var n when (n >= 60 && n < 70):
                    return "C";
                case var n when (n >= 50 && n < 60):
                    return "D";
                case var n when (n < 50):
                    return "E";
                default:
                    return "F for Failure!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                Form2 summaryForm = new Form2(average, highestMark, gradeSymbol);
                summaryForm.Show();  
           
        }
    }
}
