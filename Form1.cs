using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalStacking
{
    public partial class Form1 : Form
    {
        private Form bookStacking;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookStack_Click(object sender, EventArgs e)
        {
            ///code from: (https://stackoverflow.com/questions/6364475/how-to-switch-forms-in-c-sharp-using-a-button-event)
            ///navigates between pages
            if (bookStacking == null)
                bookStacking = new BookStacking();
            Hide();
            bookStacking.Show();
        }
    }
}
