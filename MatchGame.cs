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

            label1.MouseDown += act1_MouseDown;
            label2.MouseDown += act2_MouseDown;
            label3.MouseDown += act3_MouseDown;
            label4.MouseDown += act4_MouseDown;
            label5.MouseDown += act5_MouseDown;
            label6.MouseDown += act6_MouseDown;
            label7.MouseDown += act7_MouseDown;
            label8.MouseDown += act8_MouseDown;
            label9.MouseDown += act9_MouseDown;
            label10.MouseDown += act10_MouseDown;
        }

        //-------------------------------------------------------------------------------------------------
        //MOUSEDOWN EVENT METHODS
        /// <summary>
        /// https://stackoverflow.com/questions/1733912/how-do-i-handle-dragging-of-a-label-in-c
        /// https://stackoverflow.com/questions/11407068/how-to-drag-and-drop-a-button-from-one-panel-to-another-panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void act1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1, DragDropEffects.Move);
        }
        void act2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2, DragDropEffects.Move);
        }
        void act3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.DoDragDrop(label3, DragDropEffects.Move);
        }
        void act4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.DoDragDrop(label4, DragDropEffects.Move);
        }
        void act5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.DoDragDrop(label5, DragDropEffects.Move);
        }
        void act6_MouseDown(object sender, MouseEventArgs e)
        {
            label6.DoDragDrop(label6, DragDropEffects.Move);
        }
        void act7_MouseDown(object sender, MouseEventArgs e)
        {
            label7.DoDragDrop(label7, DragDropEffects.Move);
        }
        void act8_MouseDown(object sender, MouseEventArgs e)
        {
            label8.DoDragDrop(label8, DragDropEffects.Move);

        }
        void act9_MouseDown(object sender, MouseEventArgs e)
        {
            label9.DoDragDrop(label9, DragDropEffects.Move);
        }
        void act10_MouseDown(object sender, MouseEventArgs e)
        {
            label10.DoDragDrop(label10, DragDropEffects.Move);
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
        public static Dictionary<string, string> BoxLabels = new Dictionary<string, string>()
        {
            {"label1", "000"},
            {"label2", "111"},
            {"label3", "222"},
            {"label4", "333"},
            {"label5", "444"},
            {"label6", "555"},
            {"label7", "666"},
            {"label8", "777"},
            {"label9", "888"},
            {"label10", "999"},
        };

        public static Dictionary<string, string> BookLabels = new Dictionary<string, string>()
        {
            {"label11", "General Knowledge"},
            {"label22", "Philosophy & Psychology"},
            {"label33", "Religion"},
            {"label44", "Social Sciences"},
            {"label55", "Languages"},
            {"label66", "Science"},
            {"label77", "Technology"},
            {"label88", "Art & Recreation"},
            {"label99", "Literature"},
            {"label101", "History & Geography"},
        };
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

        private void btn_MatchHome_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btn_MatchStart_Click(object sender, EventArgs e)
        {
            PopulateBoxes();
        }

    public void PopulateBoxes()
    {
        var lastPos = 0;

        foreach (KeyValuePair<string, string> labels in BoxLabels)
        {
            Label l = new Label();
            l.Name = labels.Key;
            l.Text = labels.Value;
            l.Size = new Size(93, 12);
            l.Location = new Point(0, lastPos);

            lastPos += 15; // Adds 15 to the previous value

            flp_Boxes.Controls.Add(l);
        }
    }

    }


    }

