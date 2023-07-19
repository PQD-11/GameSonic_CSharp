using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSonic
{
    public partial class MenuGame : Form
    {
        private Mode1 frm1;
        private Mode2 frm2;

        public MenuGame()
        {
            InitializeComponent();
        }

        private void clk_NewGame(object sender, EventArgs e)
        {
            panel_ChoseMode.Visible = true;
        }

        private void clk_Quit(object sender, EventArgs e)
        {
            Close();
        }

        private void clk_Form(object sender, EventArgs e)
        {
            panel_ChoseMode.Visible = false;
        }

        private void clk_Mode1(object sender, EventArgs e)
        {
            //if (frm1 == null)
            //{
            frm1 = new Mode1();
            //}
            
            frm1.MenuGame1 = this;
            frm1.Show();
            this.Hide();
            panel_ChoseMode.Visible = false;
        }

        private void clk_Mode2(object sender, EventArgs e)
        {
            frm2 = new Mode2();
            frm2.MenuGame1 = this;
            frm2.Show();
            this.Hide();
            panel_ChoseMode.Visible = false;
        }

        private void clk_TopScore(object sender, EventArgs e)
        {
            Form frmTopScore = new TopScore();
            frmTopScore.Show();
        }

        private void clk_Instruct(object sender, EventArgs e)
        {
            Form frmInstruct = new Instruct();
            frmInstruct.Show();
        }
    }
}
