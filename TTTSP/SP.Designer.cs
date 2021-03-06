
namespace Tictactoe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanVsHumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlayerDefaulfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resertWinBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.owins = new System.Windows.Forms.Label();
            this.drawcount = new System.Windows.Forms.Label();
            this.xwins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 59);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.bclick);
            this.A1.MouseEnter += new System.EventHandler(this.b_enter);
            this.A1.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(127, 59);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.bclick);
            this.A2.MouseEnter += new System.EventHandler(this.b_enter);
            this.A2.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(242, 59);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.bclick);
            this.A3.MouseEnter += new System.EventHandler(this.b_enter);
            this.A3.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 174);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.bclick);
            this.B1.MouseEnter += new System.EventHandler(this.b_enter);
            this.B1.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 291);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.bclick);
            this.C1.MouseEnter += new System.EventHandler(this.b_enter);
            this.C1.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(127, 174);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 7;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.bclick);
            this.B2.MouseEnter += new System.EventHandler(this.b_enter);
            this.B2.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(127, 291);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.bclick);
            this.C2.MouseEnter += new System.EventHandler(this.b_enter);
            this.C2.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(242, 174);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 9;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.bclick);
            this.B3.MouseEnter += new System.EventHandler(this.b_enter);
            this.B3.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(242, 291);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.bclick);
            this.C3.MouseEnter += new System.EventHandler(this.b_enter);
            this.C3.MouseLeave += new System.EventHandler(this.b_leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanVsHumanToolStripMenuItem,
            this.setPlayerDefaulfsToolStripMenuItem,
            this.resertWinBoardToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // humanVsHumanToolStripMenuItem
            // 
            this.humanVsHumanToolStripMenuItem.Name = "humanVsHumanToolStripMenuItem";
            this.humanVsHumanToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.humanVsHumanToolStripMenuItem.Text = "Human vs human";
            this.humanVsHumanToolStripMenuItem.Click += new System.EventHandler(this.humanVsHumanToolStripMenuItem_Click);
            // 
            // setPlayerDefaulfsToolStripMenuItem
            // 
            this.setPlayerDefaulfsToolStripMenuItem.Name = "setPlayerDefaulfsToolStripMenuItem";
            this.setPlayerDefaulfsToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.setPlayerDefaulfsToolStripMenuItem.Text = "Human vs computer";
            this.setPlayerDefaulfsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaulfsToolStripMenuItem_Click);
            // 
            // resertWinBoardToolStripMenuItem
            // 
            this.resertWinBoardToolStripMenuItem.Name = "resertWinBoardToolStripMenuItem";
            this.resertWinBoardToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.resertWinBoardToolStripMenuItem.Text = "Resert win board";
            this.resertWinBoardToolStripMenuItem.Click += new System.EventHandler(this.resertWinBoardToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutGameToolStripMenuItem
            // 
            this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
            this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutGameToolStripMenuItem.Text = "About game";
            this.aboutGameToolStripMenuItem.Click += new System.EventHandler(this.aboutGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(18, 409);
            this.p1.MaximumSize = new System.Drawing.Size(100, 26);
            this.p1.MinimumSize = new System.Drawing.Size(100, 26);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 26);
            this.p1.TabIndex = 18;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(242, 409);
            this.p2.MaximumSize = new System.Drawing.Size(100, 26);
            this.p2.MinimumSize = new System.Drawing.Size(100, 26);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 26);
            this.p2.TabIndex = 19;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2TextChange);
            // 
            // owins
            // 
            this.owins.AutoSize = true;
            this.owins.BackColor = System.Drawing.Color.Transparent;
            this.owins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owins.ForeColor = System.Drawing.Color.Transparent;
            this.owins.Image = global::Tictactoe.Properties.Resources.Background;
            this.owins.Location = new System.Drawing.Point(279, 454);
            this.owins.Name = "owins";
            this.owins.Size = new System.Drawing.Size(27, 29);
            this.owins.TabIndex = 17;
            this.owins.Text = "0";
            // 
            // drawcount
            // 
            this.drawcount.AutoSize = true;
            this.drawcount.BackColor = System.Drawing.Color.Transparent;
            this.drawcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawcount.ForeColor = System.Drawing.Color.Transparent;
            this.drawcount.Image = global::Tictactoe.Properties.Resources.Background;
            this.drawcount.Location = new System.Drawing.Point(165, 454);
            this.drawcount.Name = "drawcount";
            this.drawcount.Size = new System.Drawing.Size(27, 29);
            this.drawcount.TabIndex = 16;
            this.drawcount.Text = "0";
            // 
            // xwins
            // 
            this.xwins.AutoSize = true;
            this.xwins.BackColor = System.Drawing.Color.Transparent;
            this.xwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xwins.ForeColor = System.Drawing.Color.Transparent;
            this.xwins.Image = global::Tictactoe.Properties.Resources.Background;
            this.xwins.Location = new System.Drawing.Point(48, 454);
            this.xwins.Name = "xwins";
            this.xwins.Size = new System.Drawing.Size(27, 29);
            this.xwins.TabIndex = 15;
            this.xwins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::Tictactoe.Properties.Resources.Background;
            this.label3.Location = new System.Drawing.Point(144, 411);
            this.label3.MaximumSize = new System.Drawing.Size(73, 29);
            this.label3.MinimumSize = new System.Drawing.Size(73, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Draw";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tictactoe.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(-32, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 608);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 509);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.owins);
            this.Controls.Add(this.drawcount);
            this.Controls.Add(this.xwins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(382, 565);
            this.MinimumSize = new System.Drawing.Size(382, 565);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic tac toe ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanVsHumanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xwins;
        private System.Windows.Forms.Label drawcount;
        private System.Windows.Forms.Label owins;
        private System.Windows.Forms.ToolStripMenuItem resertWinBoardToolStripMenuItem;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaulfsToolStripMenuItem;
    }
}

