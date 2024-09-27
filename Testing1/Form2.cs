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
    public partial class Form2 : Form
    {
        public Form2(double average, double highestMark, string gradeSymbol) //Form as a constructor
        {
            InitializeComponent();

            // Assuming TextBoxes named averageTextBox, highestMarkTextBox, and gradeSymbolTextBox
            averageTextBox.Text = average.ToString();
            highestMarkTextBox.Text = highestMark.ToString();
            gradeSymbolTextBox.Text = gradeSymbol;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
