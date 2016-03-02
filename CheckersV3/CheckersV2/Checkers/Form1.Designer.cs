namespace Checkers
{
    partial class Form1
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

        public string backColor;

        public static Board getBoardName()
        {
          
            return boardWindow;
        }

        public static Options getOptionsName()
        {
            return optionsWindow;
        }


        
        public void setBackColor(string newColor)
        {
            boardWindow.setBackColor(newColor);            
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boardWindow = new Checkers.Board();
            this.newGameWindow = new Checkers.NewGame();
            this.optionsWindow = new Checkers.Options();
            this.leaderboardWindow = new Checkers.Leaderboard();
            this.helpWindow = new Checkers.Help();
            this.newGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boardWindow
            // 
            this.boardWindow.ClientSize = new System.Drawing.Size(484, 462);
            this.boardWindow.Location = new System.Drawing.Point(156, 156);
            this.boardWindow.Name = "boardWindow";
            this.boardWindow.Text = "Board";
            this.boardWindow.Visible = false;
            // 
            // newGameWindow
            // 
            this.newGameWindow.ClientSize = new System.Drawing.Size(284, 262);
            this.newGameWindow.Location = new System.Drawing.Point(182, 182);
            this.newGameWindow.Name = "newGameWindow";
            this.newGameWindow.Text = "NewGame";
            this.newGameWindow.Visible = false;
            // 
            // optionsWindow
            // 
            this.optionsWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionsWindow.BackgroundImage")));
            this.optionsWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsWindow.ClientSize = new System.Drawing.Size(448, 351);
            this.optionsWindow.Location = new System.Drawing.Point(208, 208);
            this.optionsWindow.Name = "optionsWindow";
            this.optionsWindow.Text = "Options";
            this.optionsWindow.Visible = false;
            // 
            // leaderboardWindow
            // 
            this.leaderboardWindow.ClientSize = new System.Drawing.Size(284, 261);
            this.leaderboardWindow.Location = new System.Drawing.Point(234, 234);
            this.leaderboardWindow.Name = "leaderboardWindow";
            this.leaderboardWindow.Text = "Leaderboard";
            this.leaderboardWindow.Visible = false;
            // 
            // helpWindow
            // 
            this.helpWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpWindow.BackgroundImage")));
            this.helpWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpWindow.ClientSize = new System.Drawing.Size(284, 261);
            this.helpWindow.Location = new System.Drawing.Point(26, 26);
            this.helpWindow.Name = "helpWindow";
            this.helpWindow.Text = "Help";
            this.helpWindow.Visible = false;
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(93, 50);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(96, 33);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Leaderboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Checkers.Properties.Resources.checkerboard_red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public Board boardWindow;
        public NewGame newGameWindow;
        public Options optionsWindow;
        public Leaderboard leaderboardWindow;
        public Help helpWindow;
    }
}

