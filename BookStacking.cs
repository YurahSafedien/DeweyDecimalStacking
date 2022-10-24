using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DeweyDecimalStacking
{
    
    public partial class BookStacking : Form
    {

        //List<string> books = new List<string>();
        string[] books = new string[10];
        string[] sortedbooks = new string[10];
        string deweydecimal;
        int classification;
        int subClass;
        string classfic;

        //string deweydecimal;
        public BookStacking()
        {
            InitializeComponent();
            SortedPanel.AllowDrop = true;
            UnsortedPanel.AllowDrop = true;

            // DragEventHandler FlowLayoutPanel_DragEnter = null;
            UnsortedPanel.DragEnter += panel_DragEnter;
            SortedPanel.DragEnter += panel_DragEnter;

            SortedPanel.DragDrop += panel_DragDrop;
            UnsortedPanel.DragDrop += panel_DragDrop;

            book1.MouseDown += act1_MouseDown;
            book2.MouseDown += act2_MouseDown;
            book3.MouseDown += act3_MouseDown;
            book4.MouseDown += act4_MouseDown;
            book5.MouseDown += act5_MouseDown;
            book6.MouseDown += act6_MouseDown;
            book7.MouseDown += act7_MouseDown;
            book8.MouseDown += act8_MouseDown;
            book9.MouseDown += act9_MouseDown;
            book10.MouseDown += act10_MouseDown;
        }


        private void btnSortStart_Click(object sender, EventArgs e)
        {
            

            DeweyDecimalGenerator();
            PopulateList();
        }

     private void CorrectStack_Click(object sender, EventArgs e)
        {
            //DeweyDecimalGenerator();
            SortBooks();
        }
//-------------------------------------------------------------------------------------------------
        //Book Population method
        public void PopulateList()
        {
            //Array values

            book1.Text = books[0];
            book2.Text = books[1];
            book3.Text = books[2];
            book4.Text = books[3];
            book5.Text = books[4];
            book6.Text = books[5];
            book7.Text = books[6];
            book8.Text = books[7];
            book9.Text = books[8];
            book10.Text = books[9];
        }
//-------------------------------------------------------------------------------------------------
        public void SortBooks()
        {
            foreach (string sbooks in sortedbooks)
            System.Windows.MessageBox.Show(sbooks);
        }
//-------------------------------------------------------------------------------------------------
        public void DeweyDecimalGenerator()
        {

            Random ran = new Random();
            //Random Number Generator populating variables----------------------------

            ///If statement so that a 0 appears at the start of a classification number 
            ///less than 100 as per dewey decimal format
            for (int i = 0; i < 10; i++) 
            {
                classification = ran.Next(000, 999);
                subClass = ran.Next(000, 999);

                ///The if statement is to keep format when the classification 
                ///numders are below 100 or 10
                if (classification < 100)
                {
                    classfic = "0" + classification.ToString();
                     //books[i].Text = deweydecimal;
                }
                else if (classification < 10) 
                {
                    classfic = "00" + classification.ToString();
                }
                else
                {
                    classfic = classification.ToString();
                } 
                
                deweydecimal = classfic + "." + subClass.ToString();
                books[i] = deweydecimal;
                sortedbooks[i] = deweydecimal;
                
            }

            Array.Sort(sortedbooks);
        }
//-------------------------------------------------------------------------------------------------
       void act1_MouseDown(object sender, MouseEventArgs e)
        {
            book1.DoDragDrop(book1, DragDropEffects.Move);
        }
        void act2_MouseDown(object sender, MouseEventArgs e)
        {
            book2.DoDragDrop(book2, DragDropEffects.Move);
        }
        void act3_MouseDown(object sender, MouseEventArgs e)
        {
            book3.DoDragDrop(book3, DragDropEffects.Move);
        }
        void act4_MouseDown(object sender, MouseEventArgs e)
        {
            book4.DoDragDrop(book4, DragDropEffects.Move);
        }
        void act5_MouseDown(object sender, MouseEventArgs e)
        {
            book5.DoDragDrop(book5, DragDropEffects.Move);
        }
        void act6_MouseDown(object sender, MouseEventArgs e)
        {
            book6.DoDragDrop(book6, DragDropEffects.Move);
        }
        void act7_MouseDown(object sender, MouseEventArgs e)
        {
            book7.DoDragDrop(book7, DragDropEffects.Move);
        }
        void act8_MouseDown(object sender, MouseEventArgs e)
        {
            book8.DoDragDrop(book8, DragDropEffects.Move);

        }
        void act9_MouseDown(object sender, MouseEventArgs e)
        {
            book9.DoDragDrop(book9, DragDropEffects.Move);
        }
        void act10_MouseDown(object sender, MouseEventArgs e)
        {
            book10.DoDragDrop(book10, DragDropEffects.Move);
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Label)e.Data.GetData(typeof(Label))).Parent = (Panel)sender;
        }
        //-------------------------------------------------------------------------------------------------        
        //Letter generator method
        /*public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            Random ran = new Random();
            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)ran.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }*/
        //-------------------------------------------------------------------------------------------------
        private void BookStacking_Load(object sender, EventArgs e)
        {


        }
//-------------------------------------------------------------------------------------------------
        private void btnHome1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.FormClosed();
        }
//-------------------------------------------------------------------------------------------------
        
    }
}
