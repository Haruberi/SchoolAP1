using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (ResultBox.Text=="0")
                ResultBox.Clear();

            Button button = (Button)sender;
            ResultBox.Text = ResultBox.Text + button.Text;
        }
    }
}
