/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 10/31/2017
 * Time: 7:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class StartGame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel resultPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label result1;
		private System.Windows.Forms.Label result2;
		private System.Windows.Forms.Label gost;
		private System.Windows.Forms.Label domacin;
		private System.Windows.Forms.PictureBox guestPicture;
		private System.Windows.Forms.PictureBox hostPicture;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel sPanel;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button showPlayers;
		private System.Windows.Forms.Button judgeBtn;
		private System.Windows.Forms.Button subsBtn;
		private System.Windows.Forms.Button scoreBtn;
		private System.Windows.Forms.Panel column;
		private System.Windows.Forms.Button menu;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel infoLivePanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox Live_Informations;
		private System.Windows.Forms.Button cardBtn;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.infoLivePanel = new System.Windows.Forms.Panel();
			this.Live_Informations = new System.Windows.Forms.ListBox();
			this.resultPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.result1 = new System.Windows.Forms.Label();
			this.result2 = new System.Windows.Forms.Label();
			this.gost = new System.Windows.Forms.Label();
			this.domacin = new System.Windows.Forms.Label();
			this.guestPicture = new System.Windows.Forms.PictureBox();
			this.hostPicture = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.column = new System.Windows.Forms.Panel();
			this.menu = new System.Windows.Forms.Button();
			this.sPanel = new System.Windows.Forms.Panel();
			this.cardBtn = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.showPlayers = new System.Windows.Forms.Button();
			this.judgeBtn = new System.Windows.Forms.Button();
			this.subsBtn = new System.Windows.Forms.Button();
			this.scoreBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.infoLivePanel.SuspendLayout();
			this.resultPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guestPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hostPicture)).BeginInit();
			this.column.SuspendLayout();
			this.sPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.infoLivePanel);
			this.panel1.Controls.Add(this.resultPanel);
			this.panel1.Controls.Add(this.gost);
			this.panel1.Controls.Add(this.domacin);
			this.panel1.Controls.Add(this.guestPicture);
			this.panel1.Controls.Add(this.hostPicture);
			this.panel1.Location = new System.Drawing.Point(268, 11);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(704, 538);
			this.panel1.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(3, 320);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 27);
			this.label3.TabIndex = 11;
			this.label3.Text = "Live Informations";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// infoLivePanel
			// 
			this.infoLivePanel.BackColor = System.Drawing.Color.White;
			this.infoLivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.infoLivePanel.Controls.Add(this.Live_Informations);
			this.infoLivePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.infoLivePanel.Location = new System.Drawing.Point(0, 350);
			this.infoLivePanel.Name = "infoLivePanel";
			this.infoLivePanel.Size = new System.Drawing.Size(700, 184);
			this.infoLivePanel.TabIndex = 9;
			// 
			// Live_Informations
			// 
			this.Live_Informations.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Live_Informations.FormattingEnabled = true;
			this.Live_Informations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Live_Informations.ItemHeight = 19;
			this.Live_Informations.Location = new System.Drawing.Point(0, 0);
			this.Live_Informations.Name = "Live_Informations";
			this.Live_Informations.Size = new System.Drawing.Size(700, 194);
			this.Live_Informations.TabIndex = 0;
			// 
			// resultPanel
			// 
			this.resultPanel.BackColor = System.Drawing.Color.White;
			this.resultPanel.Controls.Add(this.label2);
			this.resultPanel.Controls.Add(this.result1);
			this.resultPanel.Controls.Add(this.result2);
			this.resultPanel.Location = new System.Drawing.Point(216, 102);
			this.resultPanel.Name = "resultPanel";
			this.resultPanel.Size = new System.Drawing.Size(280, 100);
			this.resultPanel.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label2.Location = new System.Drawing.Point(120, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 75);
			this.label2.TabIndex = 8;
			this.label2.Text = ":";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// result1
			// 
			this.result1.BackColor = System.Drawing.Color.White;
			this.result1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.result1.Location = new System.Drawing.Point(14, 13);
			this.result1.Name = "result1";
			this.result1.Size = new System.Drawing.Size(100, 76);
			this.result1.TabIndex = 6;
			this.result1.Text = "0";
			this.result1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// result2
			// 
			this.result2.BackColor = System.Drawing.Color.White;
			this.result2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.result2.Location = new System.Drawing.Point(169, 13);
			this.result2.Name = "result2";
			this.result2.Size = new System.Drawing.Size(100, 76);
			this.result2.TabIndex = 7;
			this.result2.Text = "0";
			this.result2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gost
			// 
			this.gost.BackColor = System.Drawing.Color.DarkSlateGray;
			this.gost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gost.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gost.ForeColor = System.Drawing.Color.White;
			this.gost.Location = new System.Drawing.Point(481, 22);
			this.gost.Name = "gost";
			this.gost.Size = new System.Drawing.Size(216, 33);
			this.gost.TabIndex = 2;
			this.gost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// domacin
			// 
			this.domacin.BackColor = System.Drawing.Color.DarkSlateGray;
			this.domacin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.domacin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.domacin.ForeColor = System.Drawing.Color.White;
			this.domacin.Location = new System.Drawing.Point(5, 22);
			this.domacin.Name = "domacin";
			this.domacin.Size = new System.Drawing.Size(216, 33);
			this.domacin.TabIndex = 0;
			this.domacin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guestPicture
			// 
			this.guestPicture.BackColor = System.Drawing.Color.White;
			this.guestPicture.Location = new System.Drawing.Point(518, 72);
			this.guestPicture.Name = "guestPicture";
			this.guestPicture.Size = new System.Drawing.Size(145, 149);
			this.guestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guestPicture.TabIndex = 4;
			this.guestPicture.TabStop = false;
			// 
			// hostPicture
			// 
			this.hostPicture.BackColor = System.Drawing.Color.White;
			this.hostPicture.Location = new System.Drawing.Point(47, 72);
			this.hostPicture.Name = "hostPicture";
			this.hostPicture.Size = new System.Drawing.Size(145, 149);
			this.hostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.hostPicture.TabIndex = 5;
			this.hostPicture.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 25;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// column
			// 
			this.column.BackColor = System.Drawing.Color.Black;
			this.column.Controls.Add(this.menu);
			this.column.Dock = System.Windows.Forms.DockStyle.Left;
			this.column.Location = new System.Drawing.Point(0, 0);
			this.column.Name = "column";
			this.column.Size = new System.Drawing.Size(59, 534);
			this.column.TabIndex = 0;
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.Color.DarkSlateGray;
			this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.menu.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu.ForeColor = System.Drawing.Color.White;
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(59, 534);
			this.menu.TabIndex = 0;
			this.menu.Text = "H\r\n\r\nI\r\n\r\nD\r\n\r\nE";
			this.menu.UseVisualStyleBackColor = false;
			this.menu.Click += new System.EventHandler(this.MenuClick);
			// 
			// sPanel
			// 
			this.sPanel.BackColor = System.Drawing.Color.White;
			this.sPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPanel.BackgroundImage")));
			this.sPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.sPanel.Controls.Add(this.cardBtn);
			this.sPanel.Controls.Add(this.exit);
			this.sPanel.Controls.Add(this.showPlayers);
			this.sPanel.Controls.Add(this.judgeBtn);
			this.sPanel.Controls.Add(this.subsBtn);
			this.sPanel.Controls.Add(this.scoreBtn);
			this.sPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sPanel.Location = new System.Drawing.Point(59, 0);
			this.sPanel.Name = "sPanel";
			this.sPanel.Size = new System.Drawing.Size(188, 534);
			this.sPanel.TabIndex = 1;
			// 
			// cardBtn
			// 
			this.cardBtn.BackColor = System.Drawing.Color.White;
			this.cardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardBtn.BackgroundImage")));
			this.cardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cardBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cardBtn.Location = new System.Drawing.Point(4, 143);
			this.cardBtn.Name = "cardBtn";
			this.cardBtn.Size = new System.Drawing.Size(176, 35);
			this.cardBtn.TabIndex = 11;
			this.cardBtn.Text = "Cards";
			this.cardBtn.UseVisualStyleBackColor = false;
			this.cardBtn.Click += new System.EventHandler(this.CardBtnClick);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.White;
			this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.exit.Location = new System.Drawing.Point(5, 225);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(176, 35);
			this.exit.TabIndex = 10;
			this.exit.Text = "Back";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// showPlayers
			// 
			this.showPlayers.BackColor = System.Drawing.Color.White;
			this.showPlayers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPlayers.BackgroundImage")));
			this.showPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.showPlayers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.showPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.showPlayers.Location = new System.Drawing.Point(3, 20);
			this.showPlayers.Name = "showPlayers";
			this.showPlayers.Size = new System.Drawing.Size(176, 35);
			this.showPlayers.TabIndex = 7;
			this.showPlayers.Text = "Show Players";
			this.showPlayers.UseVisualStyleBackColor = false;
			this.showPlayers.Click += new System.EventHandler(this.ShowPlayersClick);
			// 
			// judgeBtn
			// 
			this.judgeBtn.BackColor = System.Drawing.Color.White;
			this.judgeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("judgeBtn.BackgroundImage")));
			this.judgeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.judgeBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.judgeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.judgeBtn.Location = new System.Drawing.Point(4, 184);
			this.judgeBtn.Name = "judgeBtn";
			this.judgeBtn.Size = new System.Drawing.Size(176, 35);
			this.judgeBtn.TabIndex = 6;
			this.judgeBtn.Text = "Judges";
			this.judgeBtn.UseVisualStyleBackColor = false;
			this.judgeBtn.Click += new System.EventHandler(this.JudgeBtnClick);
			// 
			// subsBtn
			// 
			this.subsBtn.BackColor = System.Drawing.Color.White;
			this.subsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subsBtn.BackgroundImage")));
			this.subsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.subsBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.subsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.subsBtn.Location = new System.Drawing.Point(3, 102);
			this.subsBtn.Name = "subsBtn";
			this.subsBtn.Size = new System.Drawing.Size(176, 35);
			this.subsBtn.TabIndex = 9;
			this.subsBtn.Text = "Make a substitute";
			this.subsBtn.UseVisualStyleBackColor = false;
			this.subsBtn.Click += new System.EventHandler(this.SubsBtnClick);
			// 
			// scoreBtn
			// 
			this.scoreBtn.BackColor = System.Drawing.Color.White;
			this.scoreBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scoreBtn.BackgroundImage")));
			this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.scoreBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.scoreBtn.Location = new System.Drawing.Point(3, 61);
			this.scoreBtn.Name = "scoreBtn";
			this.scoreBtn.Size = new System.Drawing.Size(176, 35);
			this.scoreBtn.TabIndex = 8;
			this.scoreBtn.Text = "Change the score";
			this.scoreBtn.UseVisualStyleBackColor = false;
			this.scoreBtn.Click += new System.EventHandler(this.ScoreBtnClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.sPanel);
			this.panel2.Controls.Add(this.column);
			this.panel2.Location = new System.Drawing.Point(12, 11);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(249, 538);
			this.panel2.TabIndex = 13;
			// 
			// StartGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StartGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.infoLivePanel.ResumeLayout(false);
			this.resultPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guestPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hostPicture)).EndInit();
			this.column.ResumeLayout(false);
			this.sPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
