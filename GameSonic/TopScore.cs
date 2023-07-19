using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSonic
{
    public partial class TopScore : Form
    {
        public TopScore()
        {
            InitializeComponent();
        }

        private void TopScore_Load(object sender, EventArgs e)
        {
            string[] a = File.ReadAllLines("TopScore.txt");
            string[] S = a[0].Split(' ');
            label_Name1.Text = S[1].ToString();
            label_Score1.Text = S[2].ToString();
            S = a[1].Split(' ');
            label_Name2.Text = S[1].ToString();
            label_Score2.Text = S[2].ToString();
            S = a[2].Split(' ');
            label_Name3.Text = S[1].ToString();
            label_Score3.Text = S[2].ToString();
            S = a[3].Split(' ');
            label_Name4.Text = S[1].ToString();
            label_Score4.Text = S[2].ToString();
            S = a[4].Split(' ');
            label_Name5.Text = S[1].ToString();
            label_Score5.Text = S[2].ToString();

            string[] a2 = File.ReadAllLines("TopScoreM2.txt");
            string[] S2 = a2[0].Split(' ');
            label_Name6.Text = S2[1].ToString();
            label_Score6.Text = S2[2].ToString();
            S2 = a2[1].Split(' ');
            label_Name7.Text = S2[1].ToString();
            label_Score7.Text = S2[2].ToString();
            S2 = a2[2].Split(' ');
            label_Name8.Text = S2[1].ToString();
            label_Score8.Text = S2[2].ToString();
            S2 = a2[3].Split(' ');
            label_Name9.Text = S2[1].ToString();
            label_Score9.Text = S2[2].ToString();
            S2 = a2[4].Split(' ');
            label_Name10.Text = S2[1].ToString();
            label_Score10.Text = S2[2].ToString();
        }
    }
}
