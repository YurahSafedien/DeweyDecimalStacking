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
        public MatchGame()
        {
            InitializeComponent();
        }

        private void btn_MatchHome_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btn_MatchStart_Click(object sender, EventArgs e)
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
                
                //flp_Boxes.Controls.Add(l);
            }
        }
    }
    }

