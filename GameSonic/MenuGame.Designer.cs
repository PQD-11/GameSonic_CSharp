
namespace GameSonic
{
    partial class MenuGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGame));
            this.btn_NewGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Quit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_TopScore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Instructions = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel_ChoseMode = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_Mode2 = new Text.RJButton();
            this.btn_Mode1 = new Text.RJButton();
            this.panel_Menu.SuspendLayout();
            this.panel_ChoseMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewGame.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_NewGame.BorderRadius = 10;
            this.btn_NewGame.BorderThickness = 2;
            this.btn_NewGame.CheckedState.Parent = this.btn_NewGame;
            this.btn_NewGame.CustomImages.Parent = this.btn_NewGame;
            this.btn_NewGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NewGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NewGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NewGame.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NewGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NewGame.DisabledState.Parent = this.btn_NewGame;
            this.btn_NewGame.FillColor = System.Drawing.Color.DarkOrchid;
            this.btn_NewGame.FillColor2 = System.Drawing.Color.DarkRed;
            this.btn_NewGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.ForeColor = System.Drawing.Color.Gold;
            this.btn_NewGame.HoverState.Parent = this.btn_NewGame;
            this.btn_NewGame.Location = new System.Drawing.Point(23, 14);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.ShadowDecoration.Parent = this.btn_NewGame;
            this.btn_NewGame.Size = new System.Drawing.Size(216, 58);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "NEW GAME";
            this.btn_NewGame.Click += new System.EventHandler(this.clk_NewGame);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.btn_Quit);
            this.panel_Menu.Controls.Add(this.btn_TopScore);
            this.panel_Menu.Controls.Add(this.btn_Instructions);
            this.panel_Menu.Controls.Add(this.btn_NewGame);
            this.panel_Menu.Location = new System.Drawing.Point(554, 226);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(260, 281);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Quit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Quit.BorderRadius = 10;
            this.btn_Quit.BorderThickness = 2;
            this.btn_Quit.CheckedState.Parent = this.btn_Quit;
            this.btn_Quit.CustomImages.Parent = this.btn_Quit;
            this.btn_Quit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Quit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Quit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Quit.DisabledState.Parent = this.btn_Quit;
            this.btn_Quit.FillColor = System.Drawing.Color.DarkOrchid;
            this.btn_Quit.FillColor2 = System.Drawing.Color.DarkRed;
            this.btn_Quit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.Gold;
            this.btn_Quit.HoverState.Parent = this.btn_Quit;
            this.btn_Quit.Location = new System.Drawing.Point(23, 206);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.ShadowDecoration.Parent = this.btn_Quit;
            this.btn_Quit.Size = new System.Drawing.Size(216, 58);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "QUIT";
            this.btn_Quit.Click += new System.EventHandler(this.clk_Quit);
            // 
            // btn_TopScore
            // 
            this.btn_TopScore.BackColor = System.Drawing.Color.Transparent;
            this.btn_TopScore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TopScore.BorderRadius = 10;
            this.btn_TopScore.BorderThickness = 2;
            this.btn_TopScore.CheckedState.Parent = this.btn_TopScore;
            this.btn_TopScore.CustomImages.Parent = this.btn_TopScore;
            this.btn_TopScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TopScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TopScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TopScore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TopScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TopScore.DisabledState.Parent = this.btn_TopScore;
            this.btn_TopScore.FillColor = System.Drawing.Color.DarkOrchid;
            this.btn_TopScore.FillColor2 = System.Drawing.Color.DarkRed;
            this.btn_TopScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TopScore.ForeColor = System.Drawing.Color.Gold;
            this.btn_TopScore.HoverState.Parent = this.btn_TopScore;
            this.btn_TopScore.Location = new System.Drawing.Point(23, 78);
            this.btn_TopScore.Name = "btn_TopScore";
            this.btn_TopScore.ShadowDecoration.Parent = this.btn_TopScore;
            this.btn_TopScore.Size = new System.Drawing.Size(216, 58);
            this.btn_TopScore.TabIndex = 2;
            this.btn_TopScore.Text = "TOP SCORE";
            this.btn_TopScore.Click += new System.EventHandler(this.clk_TopScore);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.BackColor = System.Drawing.Color.Transparent;
            this.btn_Instructions.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Instructions.BorderRadius = 10;
            this.btn_Instructions.BorderThickness = 2;
            this.btn_Instructions.CheckedState.Parent = this.btn_Instructions;
            this.btn_Instructions.CustomImages.Parent = this.btn_Instructions;
            this.btn_Instructions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Instructions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Instructions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Instructions.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Instructions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Instructions.DisabledState.Parent = this.btn_Instructions;
            this.btn_Instructions.FillColor = System.Drawing.Color.DarkOrchid;
            this.btn_Instructions.FillColor2 = System.Drawing.Color.DarkRed;
            this.btn_Instructions.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instructions.ForeColor = System.Drawing.Color.Gold;
            this.btn_Instructions.HoverState.Parent = this.btn_Instructions;
            this.btn_Instructions.Location = new System.Drawing.Point(23, 142);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.ShadowDecoration.Parent = this.btn_Instructions;
            this.btn_Instructions.Size = new System.Drawing.Size(216, 58);
            this.btn_Instructions.TabIndex = 1;
            this.btn_Instructions.Text = "INSTRUCTIONS";
            this.btn_Instructions.Click += new System.EventHandler(this.clk_Instruct);
            // 
            // panel_ChoseMode
            // 
            this.panel_ChoseMode.BackColor = System.Drawing.Color.Transparent;
            this.panel_ChoseMode.BorderColor = System.Drawing.Color.Yellow;
            this.panel_ChoseMode.BorderRadius = 15;
            this.panel_ChoseMode.BorderThickness = 2;
            this.panel_ChoseMode.Controls.Add(this.btn_Mode2);
            this.panel_ChoseMode.Controls.Add(this.btn_Mode1);
            this.panel_ChoseMode.FillColor = System.Drawing.Color.Indigo;
            this.panel_ChoseMode.FillColor2 = System.Drawing.Color.Indigo;
            this.panel_ChoseMode.FillColor3 = System.Drawing.Color.Indigo;
            this.panel_ChoseMode.FillColor4 = System.Drawing.Color.Transparent;
            this.panel_ChoseMode.Location = new System.Drawing.Point(526, 94);
            this.panel_ChoseMode.Name = "panel_ChoseMode";
            this.panel_ChoseMode.ShadowDecoration.Parent = this.panel_ChoseMode;
            this.panel_ChoseMode.Size = new System.Drawing.Size(309, 140);
            this.panel_ChoseMode.TabIndex = 2;
            this.panel_ChoseMode.Visible = false;
            // 
            // btn_Mode2
            // 
            this.btn_Mode2.BackColor = System.Drawing.Color.Black;
            this.btn_Mode2.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Mode2.BackgroundImage = global::GameSonic.Properties.Resources.BGM2;
            this.btn_Mode2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Mode2.BorderRadius = 20;
            this.btn_Mode2.BorderSize = 2;
            this.btn_Mode2.FlatAppearance.BorderSize = 0;
            this.btn_Mode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mode2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Mode2.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Mode2.Location = new System.Drawing.Point(167, 27);
            this.btn_Mode2.Name = "btn_Mode2";
            this.btn_Mode2.Size = new System.Drawing.Size(121, 87);
            this.btn_Mode2.TabIndex = 1;
            this.btn_Mode2.Text = "MODE 2";
            this.btn_Mode2.TextColor = System.Drawing.Color.OrangeRed;
            this.btn_Mode2.UseVisualStyleBackColor = false;
            this.btn_Mode2.Click += new System.EventHandler(this.clk_Mode2);
            // 
            // btn_Mode1
            // 
            this.btn_Mode1.BackColor = System.Drawing.Color.Black;
            this.btn_Mode1.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Mode1.BackgroundImage = global::GameSonic.Properties.Resources.BGM2;
            this.btn_Mode1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Mode1.BorderRadius = 20;
            this.btn_Mode1.BorderSize = 2;
            this.btn_Mode1.FlatAppearance.BorderSize = 0;
            this.btn_Mode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mode1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Mode1.ForeColor = System.Drawing.Color.Gold;
            this.btn_Mode1.Location = new System.Drawing.Point(24, 27);
            this.btn_Mode1.Name = "btn_Mode1";
            this.btn_Mode1.Size = new System.Drawing.Size(121, 87);
            this.btn_Mode1.TabIndex = 0;
            this.btn_Mode1.Text = "MODE 1";
            this.btn_Mode1.TextColor = System.Drawing.Color.Gold;
            this.btn_Mode1.UseVisualStyleBackColor = false;
            this.btn_Mode1.Click += new System.EventHandler(this.clk_Mode1);
            // 
            // MenuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameSonic.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 566);
            this.Controls.Add(this.panel_ChoseMode);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGame";
            this.Click += new System.EventHandler(this.clk_Form);
            this.panel_Menu.ResumeLayout(false);
            this.panel_ChoseMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_NewGame;
        private System.Windows.Forms.Panel panel_Menu;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Instructions;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Quit;
        private Guna.UI2.WinForms.Guna2GradientButton btn_TopScore;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_ChoseMode;
        private Text.RJButton btn_Mode2;
        private Text.RJButton btn_Mode1;
    }
}