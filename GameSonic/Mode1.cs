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
    public partial class Mode1 : Form
    {
        private MenuGame menugame1;
        public MenuGame MenuGame1
        {
            set
            {
                menugame1 = value;
            }
        }
        bool flying = false;
        bool jumping = false;
        bool isGameOver = false;
        bool downing = false;
        bool undying = false;
        int key_Sonic = 0;
        int time_rand_Coin;
        int time_Incre_obsSpeed;
        int time_Incre_buocnhay;
        int time_Incre_xforce;
        int time_undying;
        int check_loa = 1;
        int Xforce;
        int force;
        int forceD;
        int buocNhay;
        int score;
        int obstacleSpeed;

        Random rand = new Random();
        List<PictureBox> listObs = new List<PictureBox>();

        int[] arrTopScore = new int[5];
        string[] arrTopName = new string[5];

        public Mode1()
        {
            InitializeComponent();
            
            listObs.Add(pic_obstacle1);
            listObs.Add(pic_obstacle2);
            listObs.Add(pic_obstacle3);

            pic_ChooseSonic.Load("../../Resources/SonicNotRun.gif");
            pic_Pause.Enabled = false;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {          
            score++;
            lb_Score.Text = "Score: " + score;

            if (flying == true)
            {
                pic_Sonic.Top = 240;
            }

            if (jumping == true && force == 0)
            {
                force = Xforce;
            }
            else if (force != 0)
            {
                if (force > (Xforce/2))
                {
                    force -= 1;
                    pic_Sonic.Top -= buocNhay;
                }
                else if (force > 0)
                {
                    force -= 1;
                    pic_Sonic.Top += buocNhay;
                }
            }
            if (pic_Sonic.Top != 346 && force == 0 && forceD == 0 && flying == false)
            {
                pic_Sonic.Top = 346;
            }

            if (downing == true && forceD == 0)
            {
                forceD = 22;
                pic_Sonic.Load(getImg_SonicDown(key_Sonic));
            }
            else if (forceD != 0)
            {
                if (forceD > 13)
                {
                    forceD -= 1;
                    pic_Sonic.Top += 2;
                }
                else if (forceD > 9)
                {
                    forceD -= 1;
                    pic_Sonic.Top += 0;
                }
                else if (forceD > 0)
                {
                    forceD -= 1;
                    pic_Sonic.Top -= 2;
                }
            }
            else if (pic_Sonic.ImageLocation == "../../Resources/DOWN.gif" || pic_Sonic.ImageLocation == "../../Resources/SuperDown.gif" || pic_Sonic.ImageLocation == "../../Resources/GokuDown.gif" || pic_Sonic.ImageLocation == "../../Resources/MegaDown.gif")
            {
                pic_Sonic.Load(getImg_SonicRun(key_Sonic));
            }

            for (int i = 0; i < listObs.Count; i++)
            {
                
                if (listObs[i].Left < 0)
                {
                    int x = this.ClientSize.Width + rand.Next(0, 1000);

                    if ((listObs[i].Name == "pic_obstacle1") && (Math.Abs(x - pic_obstacle2.Left) > 300) && (Math.Abs(x - pic_obstacle3.Left) > 300))
                    {
                        pic_obstacle1.Left = x;                        
                        pic_obstacle1.Load(getImg(rand.Next(1, 7)));
                    }
                    else if ((listObs[i].Name == "pic_obstacle2") && (Math.Abs(pic_obstacle1.Left - x) > 300) && (Math.Abs(pic_obstacle3.Left - x) > 300))
                    {
                        pic_obstacle2.Left = x;
                        pic_obstacle2.Load(getImg(rand.Next(1, 7)));
                    }
                    else if ((listObs[i].Name == "pic_obstacle3") && (Math.Abs(pic_obstacle1.Left - x) > 300) && (Math.Abs(x - pic_obstacle2.Left) > 300))
                    {
                        pic_obstacle3.Left = x;
                        pic_obstacle3.Load(getImgFly(rand.Next(1, 6)));
                    }
                }
               
                if ((pic_Sonic.Bounds.IntersectsWith(listObs[i].Bounds)) && undying == false)         //Game Over
                {
                    axHieuUng.URL = Application.StartupPath + "\\Resources\\GameOver.mp3";
                    axHieuUng.Ctlcontrols.play();

                    panel_GameOver.Visible = true;

                    //So sánh với Top điểm 
                    for (int k = 0; k < 5; k++)
                    {
                        if (score > arrTopScore[k])
                        {
                            for (int h = 4; h > k; h--)
                            {
                                arrTopScore[h] = arrTopScore[h - 1];
                                arrTopName[h] = arrTopName[h - 1];
                            }
                            arrTopScore[k] = score;
                            arrTopName[k] = lb_User.Text;
                            break;
                        }
                    }

                    string[] txtFile = File.ReadAllLines("TopScore.txt");
                    for (int z = 0; z < 5; z++)
                    {
                        txtFile[z] = "Top" + (z + 1).ToString() + " " + arrTopName[z].ToString() + " " + arrTopScore[z].ToString();
                    }

                    File.WriteAllLines("TopScore.txt", txtFile);

                    gameTimer.Stop();
                    oneSecondTimer.Stop();
                    axPlayer.Ctlcontrols.pause();
                    pic_Sonic.Load(getImg_SonicNotRun(key_Sonic));
                    isGameOver = true;
                }
                listObs[i].Left -= obstacleSpeed;
            }

            //Coin
            if (pic_Sonic.Bounds.IntersectsWith(pic_Coin.Bounds))
            {
                axHieuUng.URL = Application.StartupPath + "\\Resources\\Coin1.mp3";
                axHieuUng.Ctlcontrols.play();             

                pic_Coin.Left = -100;
                if (pic_Coin.ImageLocation == "../../Resources/GoldCoin.gif")
                {
                    score += 100;
                }
                    
                if (pic_Coin.ImageLocation == "../../Resources/ThuocBatTu.gif")
                {
                    pic_Sonic.Load("../../Resources/SonicBatTu.gif");
                    undying = true;
                    lb_TimeEvent.Visible = true;
                    pic_TimeEvent.Visible = true;
                    pic_TimeEvent.Load("../../Resources/ThuocBatTu.gif");
                }
            }
            pic_Coin.Left -= obstacleSpeed;
        }        

        private void OneSecondTimerEvent(object sender, EventArgs e)
        {
            if (Progress_Energy.Value < 100 && flying == false)
            {
                Progress_Energy.Value += 5;
            }
            else if (Progress_Energy.Value > 0 && flying == true)
            {
                Progress_Energy.Value -= 10;
            }
            else if (Progress_Energy.Value == 0 && flying == true)
            {
                flying = false;
                panel_FLy.Visible = false;
                pic_Sonic.Load(getImg_SonicRun(key_Sonic));
            }
            if (Progress_Energy.Value == 100)
            {
                panel_FLy.Visible = true;
            }

            if (time_Incre_obsSpeed != 0)
            {
                time_Incre_obsSpeed--;
            }
            else
            {
                time_Incre_obsSpeed = 10;
                obstacleSpeed++;
            }

            if (time_Incre_buocnhay != 0)
            {
                time_Incre_buocnhay--;
            }
            else
            {
                time_Incre_buocnhay = 20;
                buocNhay++;
            }

            if (time_Incre_xforce != 0)
            {
                time_Incre_xforce--;
            }
            else
            {
                time_Incre_xforce = 20;
                Xforce -= 2;
            }

            if (time_undying != 0 && undying == true)
            {
                time_undying--;
                lb_TimeEvent.Text = time_undying.ToString() + "s";
            }
            else if (time_undying == 0)
            {
                time_undying = 15;
                undying = false;
                if (flying == false)
                {
                    pic_Sonic.Load(getImg_SonicRun(key_Sonic));
                }
                lb_TimeEvent.Visible = false;
                pic_TimeEvent.Visible = false;
            }

            if (pic_Coin.Left < 0)
            {
                if (time_rand_Coin != 0)
                {
                    time_rand_Coin--;
                }
                else
                {
                    int x = this.ClientSize.Width + rand.Next(0, 150);
                    if ((Math.Abs(x - pic_obstacle1.Left) > 150) && (Math.Abs(x - pic_obstacle2.Left) > 150) && (Math.Abs(x - pic_obstacle3.Left) > 150))
                    {
                        pic_Coin.Left = x;
                        pic_Coin.Load(getImgEvent(rand.Next(1, 3)));
                    }
                    time_rand_Coin = 2;
                }
            }
        }        

        private string getImg_SonicRun(int a)
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

        private string getImg_SonicNotRun(int a)
        {
            string s = "";
            switch (a)
            {
                case 0:
                    s = "../../Resources/SonicNotRun.gif";
                    break;
                case 1:
                    s = "../../Resources/SuperNotRun.gif";
                    break;
                case 2:
                    s = "../../Resources/GokuNotRun.gif";
                    break;
                case 3:
                    s = "../../Resources/MegaNotRun.gif";
                    break;
            }
            return s;
        }

        private string getImg_SonicDown(int a)
        {
            string s = "";
            switch (a)
            {
                case 0:
                    s = "../../Resources/DOWN.gif";
                    break;
                case 1:
                    s = "../../Resources/SuperDown.gif";
                    break;
                case 2:
                    s = "../../Resources/GokuDown.gif";
                    break;
                case 3:
                    s = "../../Resources/MegaDown.gif";
                    break;
            }
            return s;
        }

        private string getImgEvent(int a)
        {
            string s = "";
            switch (a)
            {
                case 1:
                    s = "../../Resources/GoldCoin.gif";
                    break;
                case 2:
                    s = "../../Resources/ThuocBatTu.gif";
                    break;
            }
            return s;
        }

        public string getImg(int a)
        {
            string s = "";
            switch(a)
            {
                case 1:
                    s = "../../Resources/obstacle-1.gif";
                    break;
                case 2:
                    s = "../../Resources/obstacle-2.gif";
                    break;
                case 3:
                    s = "../../Resources/AmongUs1.gif";
                    break;
                case 4:
                    s = "../../Resources/Linh.gif";
                    break;
                case 5:
                    s = "../../Resources/Zoombie.gif";
                    break;
                case 6:
                    s = "../../Resources/Zoombie1.gif";
                    break;
            }
            return s;
        }

        public string getImgFly(int a)
        {
            string s = "";
            switch (a)
            {
                case 1:
                    s = "../../Resources/obstacle-3.gif";
                    break;
                case 2:
                    s = "../../Resources/Rong.gif";
                    break;
                case 3:
                    s = "../../Resources/Rong1.gif";
                    break;
                case 4:
                    s = "../../Resources/Rong2.gif";
                    break;
                case 5:
                    s = "../../Resources/Rong3.gif";
                    break;
            }
            return s;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && flying == false)
            {
                jumping = true;
                axHieuUng.URL = Application.StartupPath + "\\Resources\\Nhay1.mp3";
                axHieuUng.Ctlcontrols.play();
            }
            if (e.KeyCode == Keys.Down && flying == false)
            {
                downing = true;
            }
            if (e.KeyCode == Keys.A && force == 0 && forceD == 0)
            {
                if (flying == false && Progress_Energy.Value == 100)
                {
                    flying = true;
                    pic_Sonic.Load("../../Resources/SonicFly.gif");
                }
                else if (flying == true)
                {
                    flying = false;
                    pic_Sonic.Load(getImg_SonicRun(key_Sonic));
                    Progress_Energy.Value = 0;
                    panel_FLy.Visible = false;
                }
                
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReSet();
            }
            if (downing == true)
            {
                downing = false;
            }
        }
        
        //Game Reset
        private void GameReSet()
        {
            Progress_Energy.Value = 0;
            flying = false;
            jumping = false;
            isGameOver = false;
            undying = false;
            downing = false;
            time_rand_Coin = 2;
            time_undying = 15;
            time_Incre_buocnhay = 20;
            time_Incre_xforce = 20;
            time_Incre_obsSpeed = 10;
            Xforce = 34;
            buocNhay = 6;
            force = 0;
            forceD = 0;           
            score = 0;
            obstacleSpeed = 6;
            lb_Score.Text = "Score: " + score;         
            pic_Sonic.Load(getImg_SonicRun(key_Sonic));
            pic_Sonic.Top = 346;

            if (check_loa == 1)
            {
                axPlayer.URL = Application.StartupPath + "\\Resources\\Song1.mp3";
            }

            axPlayer.settings.setMode("loop", true);

            pic_obstacle1.Left = this.ClientSize.Width;
            pic_obstacle2.Left = this.ClientSize.Width + 300;
            pic_obstacle3.Left = this.ClientSize.Width + 900;
            pic_Coin.Left = this.ClientSize.Width + 1000;

            gameTimer.Start();
            oneSecondTimer.Start();

            panel_GameOver.Visible = false;
            panel_FLy.Visible = false;
            pic_TimeEvent.Visible = false;
            lb_TimeEvent.Visible = false;

            //Đọc File TopScore.txt
            string[] a = File.ReadAllLines("TopScore.txt");
            for (int i = 0; i < a.Length; i++)
            {
                string[] S = a[i].Split(' ');
                arrTopScore[i] = int.Parse(S[2]);
                arrTopName[i] = S[1];
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

            GameReSet();
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "NickName")
            {
                txt_User.Text = "";
            }
        }

        private void clk_Pause(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            oneSecondTimer.Enabled = false;

            panel_Pause.Visible = true;
            axPlayer.Ctlcontrols.pause();
        }

        private void clk_Continue(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            oneSecondTimer.Enabled = true;
            panel_Pause.Visible = false;
            if (check_loa == 1 )
            {
                axPlayer.Ctlcontrols.play();
            }
        }

        private void clk_Loa(object sender, EventArgs e)
        {
            if (check_loa == 1)
            {
                axPlayer.Ctlcontrols.pause();
                pic_Loa.Image = Properties.Resources.mute;
                check_loa = 0;
            }
            else
            {
                axPlayer.Ctlcontrols.play();
                pic_Loa.Image = Properties.Resources.speaker;
                check_loa = 1;
            }
        }

        private void clk_Restart(object sender, EventArgs e)
        {
            pic_Pause.Enabled = false;
            panel_Start.Visible = true;
            gameTimer.Enabled = false;
            panel_Pause.Visible = false;
            key_Sonic = 0;
            pic_ChooseSonic.Load("../../Resources/SonicNotRun.gif");
        }

        private void clk_Exit(object sender, EventArgs e)
        {
            this.Dispose();
            menugame1.Show();           
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

        private void clk_TryAgain_Yes(object sender, EventArgs e)
        {
            GameReSet();
        }

        private void Scroll_Volume(object sender, ScrollEventArgs e)
        {
            axPlayer.settings.volume = TrackBar_Volume.Value;
            axHieuUng.settings.volume = TrackBar_Volume.Value;
        }
    }
}
