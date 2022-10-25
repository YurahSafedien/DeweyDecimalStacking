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
    public partial class MatchGame : Form
    {
        double index = 1;
        Random ran = new Random();
        /// <summary>
        /// Code populated dictionaries
        /// </summary>
        Dictionary<int, string> LabelValues = new Dictionary<int, string>();
        Dictionary<int, string> LabelValues2 = new Dictionary<int, string>();
        //Dictionary<int, string> EmptyLabels = new Dictionary<int, string>();

        public MatchGame()
        {
            InitializeComponent();
            flp_Sorted1.AllowDrop = true;
            flp_Sorted2.AllowDrop = true;
            flp_Sorted3.AllowDrop = true;
            flp_Sorted4.AllowDrop = true;
            flp_Sorted5.AllowDrop = true;
            flp_Sorted6.AllowDrop = true;
            flp_Sorted7.AllowDrop = true;
            flp_Sorted8.AllowDrop = true;
            flp_Sorted9.AllowDrop = true;
            flp_Sorted10.AllowDrop = true;
            flp_Unsorted.AllowDrop = true;

            // DragEventHandler FlowLayoutPanel_DragEnter = null;
            flp_Unsorted.DragEnter += panel_DragEnter;
            flp_Sorted1.DragEnter += panel_DragEnter;
            flp_Sorted2.DragEnter += panel_DragEnter;
            flp_Sorted3.DragEnter += panel_DragEnter;
            flp_Sorted4.DragEnter += panel_DragEnter;
            flp_Sorted5.DragEnter += panel_DragEnter;
            flp_Sorted6.DragEnter += panel_DragEnter;
            flp_Sorted7.DragEnter += panel_DragEnter;
            flp_Sorted8.DragEnter += panel_DragEnter;
            flp_Sorted9.DragEnter += panel_DragEnter;
            flp_Sorted10.DragEnter += panel_DragEnter;

            flp_Sorted1.DragDrop += panel_DragDrop;
            flp_Sorted2.DragDrop += panel_DragDrop;
            flp_Sorted3.DragDrop += panel_DragDrop;
            flp_Sorted4.DragDrop += panel_DragDrop;
            flp_Sorted5.DragDrop += panel_DragDrop;
            flp_Sorted6.DragDrop += panel_DragDrop;
            flp_Sorted7.DragDrop += panel_DragDrop;
            flp_Sorted8.DragDrop += panel_DragDrop;
            flp_Sorted9.DragDrop += panel_DragDrop;
            flp_Sorted10.DragDrop += panel_DragDrop;
            flp_Unsorted.DragDrop += panel_DragDrop;

            label11.MouseDown += act1_MouseDown;
            label22.MouseDown += act2_MouseDown;
            label33.MouseDown += act3_MouseDown;
            label44.MouseDown += act4_MouseDown;
            label55.MouseDown += act5_MouseDown;
            label66.MouseDown += act6_MouseDown;
            label77.MouseDown += act7_MouseDown;
            label88.MouseDown += act8_MouseDown;
            label99.MouseDown += act9_MouseDown;
            label101.MouseDown += act10_MouseDown;
        }

        ///-------------------------------------------------------------------------------------------------
        ///MOUSEDOWN EVENT METHODS
        /// <summary>
        /// https://stackoverflow.com/questions/1733912/how-do-i-handle-dragging-of-a-label-in-c
        /// https://stackoverflow.com/questions/11407068/how-to-drag-and-drop-a-button-from-one-panel-to-another-panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void act1_MouseDown(object sender, MouseEventArgs e)
        {
            label11.DoDragDrop(label11, DragDropEffects.Move);
        }
        void act2_MouseDown(object sender, MouseEventArgs e)
        {
            label22.DoDragDrop(label22, DragDropEffects.Move);
        }
        void act3_MouseDown(object sender, MouseEventArgs e)
        {
            label33.DoDragDrop(label33, DragDropEffects.Move);
        }
        void act4_MouseDown(object sender, MouseEventArgs e)
        {
            label44.DoDragDrop(label44, DragDropEffects.Move);
        }
        void act5_MouseDown(object sender, MouseEventArgs e)
        {
            label55.DoDragDrop(label55, DragDropEffects.Move);
        }
        void act6_MouseDown(object sender, MouseEventArgs e)
        {
            label66.DoDragDrop(label66, DragDropEffects.Move);
        }
        void act7_MouseDown(object sender, MouseEventArgs e)
        {
            label77.DoDragDrop(label77, DragDropEffects.Move);
        }
        void act8_MouseDown(object sender, MouseEventArgs e)
        {
            label88.DoDragDrop(label88, DragDropEffects.Move);

        }
        void act9_MouseDown(object sender, MouseEventArgs e)
        {
            label99.DoDragDrop(label99, DragDropEffects.Move);
        }
        void act10_MouseDown(object sender, MouseEventArgs e)
        {
            label101.DoDragDrop(label101, DragDropEffects.Move);
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
        /// <summary>
        /// Dictionaries that are pre-populated
        /// </summary>
        //Decimal Code Dictionary
        public static Dictionary<int, string> CodeLabels = new Dictionary<int, string>()
        {
            {1, "000"},
            {2, "100"},
            {3, "200"},
            {4, "300"},
            {5, "400"},
            {6, "500"},
            {7, "600"},
            {8, "700"},
            {9, "800"},
            {10, "900"},
        };
        //Decimal Class Dictionary
        public static Dictionary<int, string> ClassLabels = new Dictionary<int, string>()
        {
            {1, "General Knowledge"},
            {2, "Philosophy & Psychology"},
            {3, "Religion"},
            {4, "Social Sciences"},
            {5, "Languages"},
            {6, "Science"},
            {7, "Technology"},
            {8, "Art & Recreation"},
            {9, "Literature"},
            {10, "History & Geography"},
        };
        //Correct Decimal Code to Class
        public static Dictionary<string, string> CorrectOrder = new Dictionary<string, string>()
        {
            {"000", "General Knowledge"},
            {"100", "Philosophy & Psychology"},
            {"200", "Religion"},
            {"300", "Social Sciences"},
            {"400", "Languages"},
            {"500", "Science"},
            {"600", "Technology"},
            {"700", "Art & Recreation"},
            {"800", "Literature"},
            {"900", "History & Geography"},
        };
        //-------------------------------------------------------------------------------------------------
        //public void EmptyLabelsDictionary()
        //{
        //    EmptyLabels.Add(1, label1.Text);
        //}
       
        /// <summary>
        /// Button for user to return home.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MatchHome_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        /// <summary>
        /// Start button that runs the population for the labels.
        /// Still working on how to prevent iot from being pressed more than once.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MatchStart_Click(object sender, EventArgs e)
        {
            PopulateCodes();
            PopulateClasses();
        }

        /// <summary>
        /// Decimal Code population method
        /// </summary>
        public void PopulateCodes()
        {
            for (int a = 1; a <= 10; a++)
            {
                int ranCode = ran.Next(1, 10);
                LabelValues.Add(a, CodeLabels[ranCode]);
                //LabelValues is a previosly declared dictionary
                while (true)
                {

                    if (index == 10)
                    {
                        break;
                    }
                    index++;
                }

            }

            label1.Text = LabelValues[1];
            label2.Text = LabelValues[2];
            label3.Text = LabelValues[3];
            label4.Text = LabelValues[4];
            label5.Text = LabelValues[5];
            label6.Text = LabelValues[6];
            label7.Text = LabelValues[7];
            label8.Text = LabelValues[8];
            label9.Text = LabelValues[9];
            label10.Text = LabelValues[10];

        }
    

        /// <summary>
        /// Decimal Class population method
        /// </summary>
public void PopulateClasses()
        {
            for (int i = 1; i <= 10; i++)
            {
                
                  //  string lb = LabelValues[];
                // int ranClass = ran.Next(1, 10);
                    // int ranCode = ran.Next(1, 10);
                    LabelValues2.Add(i, CorrectOrder[lb]);
                    //LabelValues is a previosly declared dictionary
                   
                while (true)
                {

                    if (index == 10)
                    {
                        break;
                    }
                    index++;
                }

            }

            label11.Text = LabelValues2[1];
            label22.Text = LabelValues2[2];
            label33.Text = LabelValues2[3];
            label44.Text = LabelValues2[4];
            label55.Text = LabelValues2[5];
            label66.Text = LabelValues2[6];
            label77.Text = LabelValues2[7];
            label88.Text = LabelValues2[8];
            label99.Text = LabelValues2[9];
            label101.Text = LabelValues2[10];

        }

    }


}

