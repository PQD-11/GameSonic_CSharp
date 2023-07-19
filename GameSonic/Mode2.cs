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
    public partial class Mode2 : Form
    {
        private MenuGame menugame1;
        public MenuGame MenuGame1
        {
            set
            {
                menugame1 = value;
            }
        }
        bool x2 = false;
        bool x2ing = false;
        bool left = false;
        bool right = false;
        bool undynig = false;
        int check_Loa = 1;
        int speed;
        int speedMeteor;
        int limitMeteor;
        int score;
        int timer_rand_x2;
        int time_x2;
        int time_update_limitMeteor;
        int time_update_speedMeteor;
        int key_Sonic = 0;
        List<PictureBox> Meteor = new List<PictureBox>();
        List<PictureBox> Line = new List<PictureBox>();
        List<PictureBox> Coin = new List<PictureBox>();
        Random rand = new Random();
        int[] index = new int[19];
        int[] arrTopScore = new int[5];
        string[] arrTopName = new string[5];

        public Mode2()
        {
            InitializeComponent();
            Line.Add(line1);
            Line.Add(line2);
            Line.Add(line3);
            Line.Add(line4);
            Line.Add(line5);
            Line.Add(line6);
            Line.Add(line7);
            Line.Add(line8);
            Line.Add(line9);
            Line.Add(line10);
            Line.Add(line11);
            Line.Add(line12);
            Line.Add(line13);
            Line.Add(line14);
            Line.Add(line15);
            Line.Add(line16);
            Line.Add(line17);
            Line.Add(line18);

            pic_Pause.Enabled = false;
        }

        private void GameStart()
        {
            x2 = false;
            x2ing = false;
            left = false;
            right = false;
            undynig = false;
            speed = 6;
            speedMeteor = 8;
            limitMeteor = 2;
            time_update_speedMeteor = 10;
            time_update_limitMeteor = 10;
            score = 0;
            timer_rand_x2 = 5;
            time_x2 = 10;
            Progress_Energy.Value = 0;

            for (int j = 0; j < Coin.Count; j++)
            {
                this.Controls.Remove(Coin[j]);
            }

            for (int j = 0; j < Meteor.Count; j++)
            {
                this.Controls.Remove(Meteor[j]);
            }

            Meteor.Clear();
            Coin.Clear();
            for (int j = 0; j < index.Length; j++)
            {
                index[j] = 0;
            }

            if (check_Loa == 1)
            {
                axPlayer.URL = Application.StartupPath + "\\Resources\\NhacNen1.mp3";
            }
            axPlayer.settings.setMode("loop", true);
            pic_Sonic.Left = 0;
            gameTimer.Enabled = true;
            OneSecondTimer.Enabled = true;
            panel_GameOver.Visible = false;

            //Đọc File TopScore.txt
            string[] a = File.ReadAllLines("TopScoreM2.txt");
            for (int i = 0; i < a.Length; i++)
            {
                string[] S = a[i].Split(' ');
                arrTopScore[i] = int.Parse(S[2]);
                arrTopName[i] = S[1];
            }

            pic_Sonic.Load(getImgSonicRight(key_Sonic));
            panel_TimeX2.Visible = false;
            panel_Fury.Visible = false;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {            
            randObstacle();
            randCoin();
            moveOjb();
            sonicMove();
        }

        private void OneSecondEvent(object sender, EventArgs e)
        {
            if (Progress_Energy.Value < 100 && undynig == false)
            {
                Progress_Energy.Value += 5;
            }
            else if (Progress_Energy.Value > 0 && undynig == true)
            {
                Progress_Energy.Value -= 10;
            }
            else if (Progress_Energy.Value == 0 && undynig == true)
            {
                undynig = false;
                panel_Fury.Visible = false;
                if (right)
                {
                    pic_Sonic.Load(getImgSonicRight(key_Sonic));
                }
                else
                {
                    pic_Sonic.Load(getImgSonicLeft(key_Sonic));
                }
                
            }

            if (Progress_Energy.Value == 100)
            {
                panel_Fury.Visible = true;
            }

            if (timer_rand_x2 != 0)
            {
                timer_rand_x2--;
            }
            else
            {
                x2 = true;
            }

            if (time_x2 != 0 && x2ing == true)
            {
                time_x2--;
                lb_TimeX2.Text = time_x2.ToString() + "s";
            }
            else if (time_x2 == 0)
            {
                time_x2 = 10;
                x2ing = false;
                panel_TimeX2.Visible = false;
                speed /= 2;
            }

            if (time_update_speedMeteor != 0)
            {
                time_update_speedMeteor--;
            }
            else
            {
                time_update_speedMeteor = 10;
                speedMeteor++;
            }
            if (time_update_limitMeteor != 0)
            {
                time_update_limitMeteor--;
            }
            else if (limitMeteor <= 10)
            {
                time_update_limitMeteor = 10;
                limitMeteor++;
            }
        }

        private string getImgSonicRight(int a)
        {
            string s = "";
            switch (a)
            {
                case 0:
                    s = "../../Resources/SonicRun.gif";
                    break;
                case 1:
                    s = "../../Resources/SuperFly.gif";
                    break;
                case 2:
                    s = "../../Resources/GokuRun.gif";
                    break;
                case 3:
                    s = "../../Resources/MegaRun.gif";
                    break;
            }
            return s;
        }
        private string getImgSonicLeft(int a)
        {
            string s = "";
            switch (a)
            {
                case 0:
                    s = "../../Resources/SonicRunLeft.gif";
                    break;
                case 1:
                    s = "../../Resources/SuperFlyLeft.gif";
                    break;
                case 2:
                    s = "../../Resources/GokuRunLeft.gif";
                    break;
                case 3:
                    s = "../../Resources/MegaRunLeft.gif";
                    break;
            }
            return s;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                left = true;
                right = false;
                if (undynig == false)
                {
                    pic_Sonic.Load(getImgSonicLeft(key_Sonic));
                }
                else
                {
                    pic_Sonic.Load("../../Resources/SonicFlyLeft.gif");
                }
                return true;
            }
            if (keyData == Keys.Right)
            {
                right = true;
                left = false;
                if (undynig == false)
                {
                    pic_Sonic.Load(getImgSonicRight(key_Sonic));
                }               
                else
                {
                    pic_Sonic.Load("../../Resources/SonicFly.gif");
                }
                return true;
            }
            if (keyData == Keys.A)
            {
                if (undynig == false && Progress_Energy.Value == 100)
                {
                    undynig = true;
                    if (right)
                    {
                        pic_Sonic.Load("../../Resources/SonicFly.gif");
                    }
                    else if (left)
                    {
                        pic_Sonic.Load("../../Resources/SonicFlyLeft.gif");
                    }
                }
                else if (undynig == true)
                {
                    undynig = false;
                    if (right)
                    {
                        pic_Sonic.Load(getImgSonicRight(key_Sonic));
                    }
                    else if (left)
                    {
                        pic_Sonic.Load(getImgSonicLeft(key_Sonic));
                    }
                    Progress_Energy.Value = 0;
                    panel_Fury.Visible = false;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }   

        private void sonicMove()
        {
            score++;
            lb_Score.Text = "Score: " + score;
            if (right)
            {              
                if (pic_Sonic.Left <= 660)
                {
                    pic_Sonic.Left += speed;
                }               
            }
            if (left)
            {
                if (pic_Sonic.Left >= 0)
                {
                    pic_Sonic.Left -= speed;
                }
            }
        }   //

        private void moveOjb()
        {
            for (int i = 0; i < Meteor.Count; i++)
            {
                Meteor[i].Top += speedMeteor;
                if (Meteor[i].Bounds.IntersectsWith(pic_Sonic.Bounds) && undynig == false)
                {
                    axHieuUng.URL = Application.StartupPath + "\\Resources\\GameOver.mp3";
                    axHieuUng.Ctlcontrols.play();
                    Meteor[i].Load("../../Resources/explosion.png");
                    gameTimer.Enabled = false;
                    OneSecondTimer.Enabled = false;
                    axPlayer.Ctlcontrols.pause();
                    panel_GameOver.Visible = true;

                    //So sánh với Top điểm 
                    for (int k = 0; k < 5; k++)
                    {
                        if ((score + 1) > arrTopScore[k])
                        {
                            for (int h = 4; h > k; h--)
                            {
                                arrTopScore[h] = arrTopScore[h - 1];
                                arrTopName[h] = arrTopName[h - 1];
                            }
                            arrTopScore[k] = score + 1;
                            arrTopName[k] = lb_User.Text;
                            break;
                        }
                    }

                    string[] txtFile = File.ReadAllLines("TopScoreM2.txt");
                    for (int z = 0; z < 5; z++)
                    {
                        txtFile[z] = "Top" + (z + 1).ToString() + " " + arrTopName[z].ToString() + " " + arrTopScore[z].ToString();
                    }

                    File.WriteAllLines("TopScoreM2.txt", txtFile);

                }
                if (Meteor[i].Top >= 480)
                {
                    this.Controls.Remove(Meteor[i]);
                    Meteor.Remove(Meteor[i]);
                }
            }

            for (int i = 0; i < Coin.Count; i++)
            {
                Coin[i].Top += speedMeteor;
                if (Coin[i].Bounds.IntersectsWith(pic_Sonic.Bounds))
                {
                    axHieuUng.URL = Application.StartupPath + "\\Resources\\Coin1.mp3";
                    axHieuUng.Ctlcontrols.play();
                    if (Coin[i].ImageLocation == "../../Resources/CoinM2.gif")
                    {
                        score += 100;
                    }

                    if (Coin[i].ImageLocation == "../../Resources/x2.gif" && x2ing == false)
                    {
                        speed *= 2;
                        x2ing = true;
                        panel_TimeX2.Visible = true;
                    }
                    this.Controls.Remove(Coin[i]);
                    Coin.Remove(Coin[i]);
                }
            }
            for (int i = 0; i < Coin.Count; i++)
            {
                if (Coin[i].Top >= 480)
                {
                    this.Controls.Remove(Coin[i]);
                    Coin.Remove(Coin[i]);
                }
            }
        }

        private void randCoin()
        {
            if (Coin.Count < 2)
            {
                int a = rand.Next(0, 18);
                while (checkLine(a) == 0)
                {
                    a = rand.Next(0, 18);
                }
                PictureBox pb = new PictureBox();
                pb.SendToBack();
                if (x2)
                {
                    pb.Load("../../Resources/x2.gif");
                    x2 = false;
                    timer_rand_x2 = 5;
                }
                else
                {
                    pb.Load("../../Resources/CoinM2.gif");
                }              
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 30;
                pb.Height = 30;
                pb.Top = Line[a].Top;
                pb.Left = Line[a].Left;
                Coin.Add(pb);
                this.Controls.Add(pb);
                pb.BackColor = Color.Transparent;
            }
        }

        private void randObstacle()
        {
            if (Meteor.Count < limitMeteor)
            {
                int a = rand.Next(0, 18);
                while (checkLine(a) == 0)
                {
                    a = rand.Next(0, 18);
                }
                PictureBox pb = new PictureBox();
                pb.SendToBack();
                int b = rand.Next(0, 4);
                if (b == 3)
                {
                    pb.Load("../../Resources/BlueBall.gif");
                }
                else if (b == 2)
                {
                    pb.Load("../../Resources/ElectricBall.gif");
                }
                else if (b == 1)
                {
                    pb.Load("../../Resources/FireBall.gif");
                }
                else if (b == 0)
                {
                    pb.Load("../../Resources/BlueFireBall.gif");
                }
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 30;
                pb.Height = 50;
                pb.Top = Line[a].Top;
                pb.Left = Line[a].Left;
                Meteor.Add(pb);
                this.Controls.Add(pb);
                pb.BackColor = Color.Transparent;
            }
        }

        private int checkLine(int a)
        {
            for (int i = 0; i < Meteor.Count + Coin.Count; i++)
            {
                if (a == index[i])
                {
                    return 0;
                }
            }
            for (int i = Meteor.Count + Coin.Count; i >= 1; i--)
            {
                index[i] = index[i - 1];
            }
            index[0] = a;
            return 1;
        }

        private void Enter_txtUser(object sender, EventArgs e)
        {
            if (txt_User.Text == "NickName")
            {
                txt_User.Text = "";
            }
        }

        private void clk_Start(object sender, EventArgs e)
        {
            pic_Pause.Enabled = true;
            panel_Start.Visible = false;
            lb_User.Text = txt_User.Text;
            txt_User.Text = "NickName";
            if (Radio_BG1.Checked == true)
            {
                this.BackgroundImage = Radio_BG1.BackgroundImage;
            }
            else if (Radio_BG2.Checked == true)
            {
                this.BackgroundImage = Radio_BG2.BackgroundImage;
            }
            else if (Radio_BG3.Checked == true)
            {
                this.BackgroundImage = Radio_BG3.BackgroundImage;
            }
            else if (Radio_BG4.Checked == true)
            {
                this.BackgroundImage = Radio_BG4.BackgroundImage;
            }
            GameStart();
        }

        private void clk_ReStart(object sender, EventArgs e)
        {
            pic_Pause.Enabled = false;
            panel_Start.Visible = true;
            gameTimer.Enabled = false;
            panel_Pause.Visible = false;
            pic_ChooseSonic.Load("../../Resources/SonicNotRun.gif");
            key_Sonic = 0;
        }

        private void clk_Pause(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            OneSecondTimer.Enabled = false;
            panel_Pause.Visible = true;
            axPlayer.Ctlcontrols.pause();
        }

        private void clk_Continue(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            OneSecondTimer.Enabled = true;
            panel_Pause.Visible = false;
            if (check_Loa == 1)
            {
                axPlayer.Ctlcontrols.play();
            }
        }

        private void clk_Loa(object sender, EventArgs e)
        {
            if (check_Loa == 1)
            {
                axPlayer.Ctlcontrols.pause();
                pic_Loa.Image = Properties.Resources.mute;
                check_Loa = 0;
            }
            else
            {
                axPlayer.Ctlcontrols.play();
                pic_Loa.Image = Properties.Resources.speaker;
                check_Loa = 1;
            }
        }

        private void clk_Exit(object sender, EventArgs e)
        {
            this.Dispose();
            menugame1.Show();
        }

        private void Scroll_Volume(object sender, ScrollEventArgs e)
        {
            axPlayer.settings.volume = TrackBar_Volume.Value;
            axHieuUng.settings.volume = TrackBar_Volume.Value;
        }

        private void clk_TryAgainYes(object sender, EventArgs e)
        {
            GameStart();
        }

        private void clk_NextSonic(object sender, EventArgs e)
        {
            if (key_Sonic == 3)
            {
                key_Sonic = 0;
            }
            else
            {
                key_Sonic++;
            }

            if (key_Sonic == 0)
            {
                pic_ChooseSonic.Load("../../Resources/SonicNotRun.gif");
            }
            else if (key_Sonic == 1)
            {
                pic_ChooseSonic.Load("../../Resources/SuperNotRun.gif");
            }
            else if (key_Sonic == 2)
            {
                pic_ChooseSonic.Load("../../Resources/GokuNotRun.gif");
            }
            else if (key_Sonic == 3)
            {
                pic_ChooseSonic.Load("../../Resources/MegaNotRun.gif");
            }
        }
    }
}
