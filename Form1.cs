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
        //private Form bookStacking;
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
           // if (game1Chapters == null)
            Game1Chapters game1Chapters = new Game1Chapters();
            Hide();
            game1Chapters.Show();
        }

        private void btnCodeMatch_Click(object sender, EventArgs e)
        {   //Code from Task 1
            /*string heading = "Coming in Soon: Match the Dewey Class!";
            string descript = "Librarian Trainees will have to match \nthe dewey class to the correct code.";
            System.Windows.MessageBox.Show(descript, heading);
            */
            MatchGame matchGame = new MatchGame();
            matchGame.Show();
            this.Hide();
        }

        private void btnCodeFind_Click(object sender, EventArgs e)
        {   //Will be added in POE
            string heading = "Coming in Soon: Find the Code!";
            string descript = "Librarian Trainees will have to find \nthe correct dewey code.";
            System.Windows.MessageBox.Show(descript, heading);
        }
    }
}
