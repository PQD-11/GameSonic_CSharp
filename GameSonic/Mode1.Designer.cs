
namespace GameSonic
{
    partial class Mode1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.oneSecondTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Pause = new Guna.UI2.WinForms.Guna2Panel();
            this.TrackBar_Volume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_Loa = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Restart = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Continue = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Start = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_ChooseSonic = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Radio_BG3 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.btn_Play = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Radio_BG4 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.Radio_BG2 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.Radio_BG1 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.panel_GameOver = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_TimeEvent = new System.Windows.Forms.Label();
            this.pic_TimeEvent = new System.Windows.Forms.PictureBox();
            this.pic_Pause = new System.Windows.Forms.PictureBox();
            this.pic_Sonic = new System.Windows.Forms.PictureBox();
            this.pic_Coin = new System.Windows.Forms.PictureBox();
            this.pic_obstacle2 = new System.Windows.Forms.PictureBox();
            this.pic_obstacle3 = new System.Windows.Forms.PictureBox();
            this.pic_obstacle1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axHieuUng = new AxWMPLib.AxWindowsMediaPlayer();
            this.axPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Progress_Energy = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.panel_FLy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Pause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loa)).BeginInit();
            this.panel_Start.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChooseSonic)).BeginInit();
            this.panel_GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimeEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axHieuUng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).BeginInit();
            this.panel_FLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.Color.Indigo;
            this.lb_User.Location = new System.Drawing.Point(21, 12);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(56, 21);
            this.lb_User.TabIndex = 4;
            this.lb_User.Text = "User";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.BackColor = System.Drawing.Color.Transparent;
            this.lb_Score.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.ForeColor = System.Drawing.Color.Indigo;
            this.lb_Score.Location = new System.Drawing.Point(554, 12);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(89, 21);
            this.lb_Score.TabIndex = 0;
            this.lb_Score.Text = "Score: 0";
            // 
            // oneSecondTimer
            // 
            this.oneSecondTimer.Interval = 1000;
            this.oneSecondTimer.Tick += new System.EventHandler(this.OneSecondTimerEvent);
            // 
            // panel_Pause
            // 
            this.panel_Pause.BackColor = System.Drawing.Color.Transparent;
            this.panel_Pause.BorderColor = System.Drawing.Color.Orange;
            this.panel_Pause.BorderRadius = 15;
            this.panel_Pause.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel_Pause.BorderThickness = 3;
            this.panel_Pause.Controls.Add(this.TrackBar_Volume);
            this.panel_Pause.Controls.Add(this.label2);
            this.panel_Pause.Controls.Add(this.pic_Loa);
            this.panel_Pause.Controls.Add(this.btn_Exit);
            this.panel_Pause.Controls.Add(this.btn_Restart);
            this.panel_Pause.Controls.Add(this.btn_Continue);
            this.panel_Pause.FillColor = System.Drawing.Color.SaddleBrown;
            this.panel_Pause.Location = new System.Drawing.Point(290, 7);
            this.panel_Pause.Name = "panel_Pause";
            this.panel_Pause.ShadowDecoration.Parent = this.panel_Pause;
            this.panel_Pause.Size = new System.Drawing.Size(230, 338);
            this.panel_Pause.TabIndex = 53;
            this.panel_Pause.Visible = false;
            // 
            // TrackBar_Volume
            // 
            this.TrackBar_Volume.FillColor = System.Drawing.Color.White;
            this.TrackBar_Volume.HoverState.Parent = this.TrackBar_Volume;
            this.TrackBar_Volume.Location = new System.Drawing.Point(25, 135);
            this.TrackBar_Volume.Name = "TrackBar_Volume";
            this.TrackBar_Volume.Size = new System.Drawing.Size(181, 25);
            this.TrackBar_Volume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.TrackBar_Volume.TabIndex = 8;
            this.TrackBar_Volume.ThumbColor = System.Drawing.Color.MediumSlateBlue;
            this.TrackBar_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Volume);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "PAUSED";
            // 
            // pic_Loa
            // 
            this.pic_Loa.Image = global::GameSonic.Properties.Resources.speaker;
            this.pic_Loa.Location = new System.Drawing.Point(90, 71);
            this.pic_Loa.Name = "pic_Loa";
            this.pic_Loa.Size = new System.Drawing.Size(50, 50);
            this.pic_Loa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Loa.TabIndex = 6;
            this.pic_Loa.TabStop = false;
            this.pic_Loa.Click += new System.EventHandler(this.clk_Loa);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Exit.BorderRadius = 5;
            this.btn_Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Exit.BorderThickness = 2;
            this.btn_Exit.CheckedState.Parent = this.btn_Exit;
            this.btn_Exit.CustomImages.Parent = this.btn_Exit;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.DisabledState.Parent = this.btn_Exit;
            this.btn_Exit.FillColor = System.Drawing.Color.Maroon;
            this.btn_Exit.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.Parent = this.btn_Exit;
            this.btn_Exit.Location = new System.Drawing.Point(45, 277);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Parent = this.btn_Exit;
            this.btn_Exit.Size = new System.Drawing.Size(142, 39);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.clk_Exit);
            // 
            // btn_Restart
            // 
            this.btn_Restart.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Restart.BorderRadius = 5;
            this.btn_Restart.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Restart.BorderThickness = 2;
            this.btn_Restart.CheckedState.Parent = this.btn_Restart;
            this.btn_Restart.CustomImages.Parent = this.btn_Restart;
            this.btn_Restart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Restart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Restart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Restart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Restart.DisabledState.Parent = this.btn_Restart;
            this.btn_Restart.FillColor = System.Drawing.Color.Maroon;
            this.btn_Restart.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.ForeColor = System.Drawing.Color.White;
            this.btn_Restart.HoverState.Parent = this.btn_Restart;
            this.btn_Restart.Location = new System.Drawing.Point(45, 231);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.ShadowDecoration.Parent = this.btn_Restart;
            this.btn_Restart.Size = new System.Drawing.Size(142, 40);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.Text = "Replay";
            this.btn_Restart.Click += new System.EventHandler(this.clk_Restart);
            // 
            // btn_Continue
            // 
            this.btn_Continue.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Continue.BorderRadius = 5;
            this.btn_Continue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Continue.BorderThickness = 2;
            this.btn_Continue.CheckedState.Parent = this.btn_Continue;
            this.btn_Continue.CustomImages.Parent = this.btn_Continue;
            this.btn_Continue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Continue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Continue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Continue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Continue.DisabledState.Parent = this.btn_Continue;
            this.btn_Continue.FillColor = System.Drawing.Color.Maroon;
            this.btn_Continue.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.ForeColor = System.Drawing.Color.White;
            this.btn_Continue.HoverState.Parent = this.btn_Continue;
            this.btn_Continue.Location = new System.Drawing.Point(45, 184);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.ShadowDecoration.Parent = this.btn_Continue;
            this.btn_Continue.Size = new System.Drawing.Size(142, 41);
            this.btn_Continue.TabIndex = 4;
            this.btn_Continue.Text = "Resume";
            this.btn_Continue.Click += new System.EventHandler(this.clk_Continue);
            // 
            // panel_Start
            // 
            this.panel_Start.BackColor = System.Drawing.Color.Transparent;
            this.panel_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Start.BackgroundImage")));
            this.panel_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Start.BorderColor = System.Drawing.Color.Linen;
            this.panel_Start.BorderRadius = 15;
            this.panel_Start.Controls.Add(this.txt_User);
            this.panel_Start.Controls.Add(this.guna2Panel1);
            this.panel_Start.Controls.Add(this.guna2HtmlLabel1);
            this.panel_Start.Controls.Add(this.Radio_BG3);
            this.panel_Start.Controls.Add(this.btn_Play);
            this.panel_Start.Controls.Add(this.Radio_BG4);
            this.panel_Start.Controls.Add(this.Radio_BG2);
            this.panel_Start.Controls.Add(this.Radio_BG1);
            this.panel_Start.FillColor = System.Drawing.Color.Transparent;
            this.panel_Start.Location = new System.Drawing.Point(146, 37);
            this.panel_Start.Name = "panel_Start";
            this.panel_Start.ShadowDecoration.Parent = this.panel_Start;
            this.panel_Start.Size = new System.Drawing.Size(507, 359);
            this.panel_Start.TabIndex = 55;
            // 
            // txt_User
            // 
            this.txt_User.BorderColor = System.Drawing.Color.Cyan;
            this.txt_User.BorderRadius = 5;
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.DefaultText = "NickName";
            this.txt_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.DisabledState.Parent = this.txt_User;
            this.txt_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.FillColor = System.Drawing.Color.HotPink;
            this.txt_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_User.FocusedState.Parent = this.txt_User;
            this.txt_User.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Cyan;
            this.txt_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_User.HoverState.Parent = this.txt_User;
            this.txt_User.Location = new System.Drawing.Point(149, 242);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_User.Name = "txt_User";
            this.txt_User.PasswordChar = '\0';
            this.txt_User.PlaceholderText = "";
            this.txt_User.SelectedText = "";
            this.txt_User.SelectionStart = 8;
            this.txt_User.ShadowDecoration.Parent = this.txt_User;
            this.txt_User.Size = new System.Drawing.Size(222, 33);
            this.txt_User.TabIndex = 12;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_User.Enter += new System.EventHandler(this.txt_User_Enter);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.pic_ChooseSonic);
            this.guna2Panel1.Location = new System.Drawing.Point(207, 113);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(106, 99);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::GameSonic.Properties.Resources.Next;
            this.guna2PictureBox2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(75, 37);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(26, 26);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.clk_NextSonic);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GameSonic.Properties.Resources.Next;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 37);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(26, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.clk_NextSonic);
            // 
            // pic_ChooseSonic
            // 
            this.pic_ChooseSonic.Image = global::GameSonic.Properties.Resources.SonicNotRun;
            this.pic_ChooseSonic.Location = new System.Drawing.Point(35, 28);
            this.pic_ChooseSonic.Name = "pic_ChooseSonic";
            this.pic_ChooseSonic.Size = new System.Drawing.Size(40, 50);
            this.pic_ChooseSonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_ChooseSonic.TabIndex = 10;
            this.pic_ChooseSonic.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(209, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(102, 44);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "SONIC";
            // 
            // Radio_BG3
            // 
            this.Radio_BG3.BackgroundImage = global::GameSonic.Properties.Resources.Afternoon;
            this.Radio_BG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Radio_BG3.CheckedState.Image = global::GameSonic.Properties.Resources.Checked;
            this.Radio_BG3.CheckedState.Parent = this.Radio_BG3;
            this.Radio_BG3.HoverState.Parent = this.Radio_BG3;
            this.Radio_BG3.Image = ((System.Drawing.Image)(resources.GetObject("Radio_BG3.Image")));
            this.Radio_BG3.ImageOffset = new System.Drawing.Point(0, 0);
            this.Radio_BG3.ImageRotate = 0F;
            this.Radio_BG3.Location = new System.Drawing.Point(325, 93);
            this.Radio_BG3.Name = "Radio_BG3";
            this.Radio_BG3.PressedState.Parent = this.Radio_BG3;
            this.Radio_BG3.ShadowDecoration.Parent = this.Radio_BG3;
            this.Radio_BG3.Size = new System.Drawing.Size(90, 60);
            this.Radio_BG3.TabIndex = 6;
            // 
            // btn_Play
            // 
            this.btn_Play.BorderRadius = 5;
            this.btn_Play.CheckedState.Parent = this.btn_Play;
            this.btn_Play.CustomImages.Parent = this.btn_Play;
            this.btn_Play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Play.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Play.DisabledState.Parent = this.btn_Play;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.HoverState.Parent = this.btn_Play;
            this.btn_Play.Location = new System.Drawing.Point(184, 283);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.ShadowDecoration.Parent = this.btn_Play;
            this.btn_Play.Size = new System.Drawing.Size(152, 35);
            this.btn_Play.TabIndex = 8;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.Click += new System.EventHandler(this.clk_Start);
            // 
            // Radio_BG4
            // 
            this.Radio_BG4.BackgroundImage = global::GameSonic.Properties.Resources.Winter;
            this.Radio_BG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Radio_BG4.CheckedState.Image = global::GameSonic.Properties.Resources.Checked;
            this.Radio_BG4.CheckedState.Parent = this.Radio_BG4;
            this.Radio_BG4.HoverState.Parent = this.Radio_BG4;
            this.Radio_BG4.Image = ((System.Drawing.Image)(resources.GetObject("Radio_BG4.Image")));
            this.Radio_BG4.ImageOffset = new System.Drawing.Point(0, 0);
            this.Radio_BG4.ImageRotate = 0F;
            this.Radio_BG4.Location = new System.Drawing.Point(325, 172);
            this.Radio_BG4.Name = "Radio_BG4";
            this.Radio_BG4.PressedState.Parent = this.Radio_BG4;
            this.Radio_BG4.ShadowDecoration.Parent = this.Radio_BG4;
            this.Radio_BG4.Size = new System.Drawing.Size(90, 60);
            this.Radio_BG4.TabIndex = 5;
            // 
            // Radio_BG2
            // 
            this.Radio_BG2.BackgroundImage = global::GameSonic.Properties.Resources.Night;
            this.Radio_BG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Radio_BG2.CheckedState.Image = global::GameSonic.Properties.Resources.Checked;
            this.Radio_BG2.CheckedState.Parent = this.Radio_BG2;
            this.Radio_BG2.HoverState.Parent = this.Radio_BG2;
            this.Radio_BG2.Image = ((System.Drawing.Image)(resources.GetObject("Radio_BG2.Image")));
            this.Radio_BG2.ImageOffset = new System.Drawing.Point(0, 0);
            this.Radio_BG2.ImageRotate = 0F;
            this.Radio_BG2.Location = new System.Drawing.Point(103, 93);
            this.Radio_BG2.Name = "Radio_BG2";
            this.Radio_BG2.PressedState.Parent = this.Radio_BG2;
            this.Radio_BG2.ShadowDecoration.Parent = this.Radio_BG2;
            this.Radio_BG2.Size = new System.Drawing.Size(90, 60);
            this.Radio_BG2.TabIndex = 4;
            // 
            // Radio_BG1
            // 
            this.Radio_BG1.BackgroundImage = global::GameSonic.Properties.Resources.Bluemoon;
            this.Radio_BG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Radio_BG1.Checked = true;
            this.Radio_BG1.CheckedState.Image = global::GameSonic.Properties.Resources.Checked;
            this.Radio_BG1.CheckedState.Parent = this.Radio_BG1;
            this.Radio_BG1.HoverState.Parent = this.Radio_BG1;
            this.Radio_BG1.Image = ((System.Drawing.Image)(resources.GetObject("Radio_BG1.Image")));
            this.Radio_BG1.ImageOffset = new System.Drawing.Point(0, 0);
            this.Radio_BG1.ImageRotate = 0F;
            this.Radio_BG1.Location = new System.Drawing.Point(103, 172);
            this.Radio_BG1.Name = "Radio_BG1";
            this.Radio_BG1.PressedState.Parent = this.Radio_BG1;
            this.Radio_BG1.ShadowDecoration.Parent = this.Radio_BG1;
            this.Radio_BG1.Size = new System.Drawing.Size(90, 60);
            this.Radio_BG1.TabIndex = 0;
            // 
            // panel_GameOver
            // 
            this.panel_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.panel_GameOver.BackgroundImage = global::GameSonic.Properties.Resources.GameOver;
            this.panel_GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_GameOver.BorderColor = System.Drawing.Color.Transparent;
            this.panel_GameOver.Controls.Add(this.button2);
            this.panel_GameOver.Controls.Add(this.button1);
            this.panel_GameOver.FillColor = System.Drawing.Color.Transparent;
            this.panel_GameOver.FillColor2 = System.Drawing.Color.Transparent;
            this.panel_GameOver.FillColor3 = System.Drawing.Color.Transparent;
            this.panel_GameOver.FillColor4 = System.Drawing.Color.Transparent;
            this.panel_GameOver.Location = new System.Drawing.Point(133, 65);
            this.panel_GameOver.Name = "panel_GameOver";
            this.panel_GameOver.ShadowDecoration.Parent = this.panel_GameOver;
            this.panel_GameOver.Size = new System.Drawing.Size(535, 281);
            this.panel_GameOver.TabIndex = 59;
            this.panel_GameOver.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("NSimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(283, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clk_Exit);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("NSimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(190, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clk_TryAgain_Yes);
            // 
            // lb_TimeEvent
            // 
            this.lb_TimeEvent.AutoSize = true;
            this.lb_TimeEvent.BackColor = System.Drawing.Color.Transparent;
            this.lb_TimeEvent.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeEvent.ForeColor = System.Drawing.Color.White;
            this.lb_TimeEvent.Location = new System.Drawing.Point(709, 20);
            this.lb_TimeEvent.Name = "lb_TimeEvent";
            this.lb_TimeEvent.Size = new System.Drawing.Size(28, 22);
            this.lb_TimeEvent.TabIndex = 61;
            this.lb_TimeEvent.Text = "15";
            this.lb_TimeEvent.Visible = false;
            // 
            // pic_TimeEvent
            // 
            this.pic_TimeEvent.BackColor = System.Drawing.Color.Transparent;
            this.pic_TimeEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_TimeEvent.Location = new System.Drawing.Point(674, 12);
            this.pic_TimeEvent.Name = "pic_TimeEvent";
            this.pic_TimeEvent.Size = new System.Drawing.Size(34, 33);
            this.pic_TimeEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TimeEvent.TabIndex = 62;
            this.pic_TimeEvent.TabStop = false;
            this.pic_TimeEvent.Visible = false;
            // 
            // pic_Pause
            // 
            this.pic_Pause.BackColor = System.Drawing.Color.Transparent;
            this.pic_Pause.Image = global::GameSonic.Properties.Resources.Pause;
            this.pic_Pause.Location = new System.Drawing.Point(743, 12);
            this.pic_Pause.Name = "pic_Pause";
            this.pic_Pause.Size = new System.Drawing.Size(50, 50);
            this.pic_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pause.TabIndex = 54;
            this.pic_Pause.TabStop = false;
            this.pic_Pause.Click += new System.EventHandler(this.clk_Pause);
            // 
            // pic_Sonic
            // 
            this.pic_Sonic.BackColor = System.Drawing.Color.Transparent;
            this.pic_Sonic.Image = global::GameSonic.Properties.Resources.SonicNotRun;
            this.pic_Sonic.Location = new System.Drawing.Point(205, 346);
            this.pic_Sonic.Name = "pic_Sonic";
            this.pic_Sonic.Size = new System.Drawing.Size(40, 50);
            this.pic_Sonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Sonic.TabIndex = 2;
            this.pic_Sonic.TabStop = false;
            // 
            // pic_Coin
            // 
            this.pic_Coin.BackColor = System.Drawing.Color.Transparent;
            this.pic_Coin.Image = global::GameSonic.Properties.Resources.GoldCoin;
            this.pic_Coin.Location = new System.Drawing.Point(295, 352);
            this.pic_Coin.Name = "pic_Coin";
            this.pic_Coin.Size = new System.Drawing.Size(44, 44);
            this.pic_Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Coin.TabIndex = 47;
            this.pic_Coin.TabStop = false;
            // 
            // pic_obstacle2
            // 
            this.pic_obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.pic_obstacle2.Image = global::GameSonic.Properties.Resources.obstacle_2;
            this.pic_obstacle2.Location = new System.Drawing.Point(562, 354);
            this.pic_obstacle2.Name = "pic_obstacle2";
            this.pic_obstacle2.Size = new System.Drawing.Size(46, 42);
            this.pic_obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_obstacle2.TabIndex = 5;
            this.pic_obstacle2.TabStop = false;
            this.pic_obstacle2.Tag = "obstacle2";
            // 
            // pic_obstacle3
            // 
            this.pic_obstacle3.BackColor = System.Drawing.Color.Transparent;
            this.pic_obstacle3.Image = global::GameSonic.Properties.Resources.Rong3;
            this.pic_obstacle3.Location = new System.Drawing.Point(415, 314);
            this.pic_obstacle3.Name = "pic_obstacle3";
            this.pic_obstacle3.Size = new System.Drawing.Size(50, 35);
            this.pic_obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_obstacle3.TabIndex = 4;
            this.pic_obstacle3.TabStop = false;
            this.pic_obstacle3.Tag = "obstacle3";
            // 
            // pic_obstacle1
            // 
            this.pic_obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.pic_obstacle1.Image = global::GameSonic.Properties.Resources.Zoombie1;
            this.pic_obstacle1.Location = new System.Drawing.Point(502, 354);
            this.pic_obstacle1.Name = "pic_obstacle1";
            this.pic_obstacle1.Size = new System.Drawing.Size(32, 42);
            this.pic_obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_obstacle1.TabIndex = 3;
            this.pic_obstacle1.TabStop = false;
            this.pic_obstacle1.Tag = "obstacle1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameSonic.Properties.Resources.grass;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(874, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // axHieuUng
            // 
            this.axHieuUng.Enabled = true;
            this.axHieuUng.Location = new System.Drawing.Point(674, 298);
            this.axHieuUng.Name = "axHieuUng";
            this.axHieuUng.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHieuUng.OcxState")));
            this.axHieuUng.Size = new System.Drawing.Size(104, 46);
            this.axHieuUng.TabIndex = 57;
            this.axHieuUng.Visible = false;
            // 
            // axPlayer
            // 
            this.axPlayer.Enabled = true;
            this.axPlayer.Location = new System.Drawing.Point(674, 350);
            this.axPlayer.Name = "axPlayer";
            this.axPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer.OcxState")));
            this.axPlayer.Size = new System.Drawing.Size(104, 46);
            this.axPlayer.TabIndex = 46;
            this.axPlayer.Visible = false;
            // 
            // Progress_Energy
            // 
            this.Progress_Energy.BackColor = System.Drawing.Color.Transparent;
            this.Progress_Energy.BorderColor = System.Drawing.Color.Yellow;
            this.Progress_Energy.BorderRadius = 2;
            this.Progress_Energy.BorderThickness = 2;
            this.Progress_Energy.FillColor = System.Drawing.Color.Transparent;
            this.Progress_Energy.Location = new System.Drawing.Point(248, 9);
            this.Progress_Energy.Name = "Progress_Energy";
            this.Progress_Energy.ProgressColor = System.Drawing.Color.Yellow;
            this.Progress_Energy.ProgressColor2 = System.Drawing.Color.Red;
            this.Progress_Energy.ShadowDecoration.Parent = this.Progress_Energy;
            this.Progress_Energy.Size = new System.Drawing.Size(300, 30);
            this.Progress_Energy.TabIndex = 63;
            this.Progress_Energy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel_FLy
            // 
            this.panel_FLy.BackColor = System.Drawing.Color.Transparent;
            this.panel_FLy.BackgroundImage = global::GameSonic.Properties.Resources.Img_btnFly;
            this.panel_FLy.Controls.Add(this.label1);
            this.panel_FLy.Controls.Add(this.pictureBox2);
            this.panel_FLy.Location = new System.Drawing.Point(10, 42);
            this.panel_FLy.Name = "panel_FLy";
            this.panel_FLy.Size = new System.Drawing.Size(100, 100);
            this.panel_FLy.TabIndex = 64;
            this.panel_FLy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GameSonic.Properties.Resources.Img_EvFly;
            this.pictureBox2.Location = new System.Drawing.Point(34, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 40);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // Mode1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GameSonic.Properties.Resources.Afternoon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.panel_Pause);
            this.Controls.Add(this.panel_FLy);
            this.Controls.Add(this.Progress_Energy);
            this.Controls.Add(this.pic_TimeEvent);
            this.Controls.Add(this.lb_TimeEvent);
            this.Controls.Add(this.axHieuUng);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.pic_Pause);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.axPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Start);
            this.Controls.Add(this.panel_GameOver);
            this.Controls.Add(this.pic_Sonic);
            this.Controls.Add(this.pic_Coin);
            this.Controls.Add(this.pic_obstacle1);
            this.Controls.Add(this.pic_obstacle2);
            this.Controls.Add(this.pic_obstacle3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Mode1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel_Pause.ResumeLayout(false);
            this.panel_Pause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loa)).EndInit();
            this.panel_Start.ResumeLayout(false);
            this.panel_Start.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChooseSonic)).EndInit();
            this.panel_GameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimeEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axHieuUng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).EndInit();
            this.panel_FLy.ResumeLayout(false);
            this.panel_FLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_Sonic;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pic_obstacle1;
        private System.Windows.Forms.PictureBox pic_obstacle3;
        private System.Windows.Forms.PictureBox pic_obstacle2;
        private AxWMPLib.AxWindowsMediaPlayer axPlayer;
        private System.Windows.Forms.PictureBox pic_Coin;
        private System.Windows.Forms.Timer oneSecondTimer;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.PictureBox pic_Loa;
        private Guna.UI2.WinForms.Guna2Panel panel_Pause;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_Restart;
        private Guna.UI2.WinForms.Guna2Button btn_Continue;
        private System.Windows.Forms.PictureBox pic_Pause;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panel_Start;
        private AxWMPLib.AxWindowsMediaPlayer axHieuUng;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_GameOver;
        private System.Windows.Forms.Label lb_TimeEvent;
        private System.Windows.Forms.PictureBox pic_TimeEvent;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Radio_BG1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Radio_BG2;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Radio_BG3;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Radio_BG4;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Play;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pic_ChooseSonic;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_User;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2ProgressBar Progress_Energy;
        private System.Windows.Forms.Panel panel_FLy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar_Volume;
    }
}

