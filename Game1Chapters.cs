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
    public partial class Game1Chapters : Form
    {
        public Game1Chapters()
        {
            InitializeComponent();
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnEasy1_Click(object sender, EventArgs e)
        {
            BookStacking bookStacking = new BookStacking();
            Hide();
            bookStacking.Show();
        }
    }
}
