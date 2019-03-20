/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/21/2017
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class Kartoni
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel wraperPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel guestP;
		private System.Windows.Forms.Panel hostP;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox redCardGuest;
		private System.Windows.Forms.CheckBox yellowCardGuest;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button assCardGuest;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label labChooseP;
		private System.Windows.Forms.ComboBox cbPlayers;
		private System.Windows.Forms.Label labChooseC;
		private System.Windows.Forms.CheckBox redCardHost;
		private System.Windows.Forms.CheckBox yellowCardHost;
		private System.Windows.Forms.PictureBox pbCards;
		private System.Windows.Forms.Button assCardHost;
		private System.Windows.Forms.Button butBackCards;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kartoni));
			this.wraperPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.hostP = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labChooseP = new System.Windows.Forms.Label();
			this.cbPlayers = new System.Windows.Forms.ComboBox();
			this.labChooseC = new System.Windows.Forms.Label();
			this.redCardHost = new System.Windows.Forms.CheckBox();
			this.yellowCardHost = new System.Windows.Forms.CheckBox();
			this.pbCards = new System.Windows.Forms.PictureBox();
			this.assCardHost = new System.Windows.Forms.Button();
			this.butBackCards = new System.Windows.Forms.Button();
			this.guestP = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.redCardGuest = new System.Windows.Forms.CheckBox();
			this.yellowCardGuest = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.assCardGuest = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.wraperPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.hostP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCards)).BeginInit();
			this.guestP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// wraperPanel
			// 
			this.wraperPanel.Controls.Add(this.panel1);
			this.wraperPanel.Controls.Add(this.guestP);
			this.wraperPanel.Controls.Add(this.hostP);
			this.wraperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wraperPanel.Location = new System.Drawing.Point(0, 0);
			this.wraperPanel.Name = "wraperPanel";
			this.wraperPanel.Size = new System.Drawing.Size(452, 329);
			this.wraperPanel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 30);
			this.panel1.TabIndex = 0;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(272, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(144, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Guest";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(37, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Host";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// hostP
			// 
			this.hostP.BackColor = System.Drawing.Color.White;
			this.hostP.Controls.Add(this.pictureBox2);
			this.hostP.Controls.Add(this.labChooseP);
			this.hostP.Controls.Add(this.cbPlayers);
			this.hostP.Controls.Add(this.labChooseC);
			this.hostP.Controls.Add(this.redCardHost);
			this.hostP.Controls.Add(this.yellowCardHost);
			this.hostP.Controls.Add(this.pbCards);
			this.hostP.Controls.Add(this.assCardHost);
			this.hostP.Controls.Add(this.butBackCards);
			this.hostP.Location = new System.Drawing.Point(0, 33);
			this.hostP.Name = "hostP";
			this.hostP.Size = new System.Drawing.Size(452, 296);
			this.hostP.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(266, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(158, 141);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// labChooseP
			// 
			this.labChooseP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labChooseP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labChooseP.Location = new System.Drawing.Point(266, 9);
			this.labChooseP.Name = "labChooseP";
			this.labChooseP.Size = new System.Drawing.Size(158, 23);
			this.labChooseP.TabIndex = 43;
			this.labChooseP.Text = "Choose player";
			this.labChooseP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbPlayers
			// 
			this.cbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPlayers.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPlayers.FormattingEnabled = true;
			this.cbPlayers.Location = new System.Drawing.Point(266, 35);
			this.cbPlayers.Name = "cbPlayers";
			this.cbPlayers.Size = new System.Drawing.Size(158, 23);
			this.cbPlayers.TabIndex = 42;
			// 
			// labChooseC
			// 
			this.labChooseC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labChooseC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labChooseC.Location = new System.Drawing.Point(37, 9);
			this.labChooseC.Name = "labChooseC";
			this.labChooseC.Size = new System.Drawing.Size(147, 23);
			this.labChooseC.TabIndex = 41;
			this.labChooseC.Text = "Choose a card";
			this.labChooseC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// redCardHost
			// 
			this.redCardHost.Location = new System.Drawing.Point(157, 171);
			this.redCardHost.Name = "redCardHost";
			this.redCardHost.Size = new System.Drawing.Size(34, 24);
			this.redCardHost.TabIndex = 40;
			this.redCardHost.UseVisualStyleBackColor = true;
			this.redCardHost.CheckedChanged += new System.EventHandler(this.RedCardHostCheckedChanged);
			// 
			// yellowCardHost
			// 
			this.yellowCardHost.Location = new System.Drawing.Point(54, 171);
			this.yellowCardHost.Name = "yellowCardHost";
			this.yellowCardHost.Size = new System.Drawing.Size(38, 24);
			this.yellowCardHost.TabIndex = 39;
			this.yellowCardHost.UseVisualStyleBackColor = true;
			this.yellowCardHost.CheckedChanged += new System.EventHandler(this.YellowCardHostCheckedChanged);
			// 
			// pbCards
			// 
			this.pbCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbCards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbCards.Image = ((System.Drawing.Image)(resources.GetObject("pbCards.Image")));
			this.pbCards.InitialImage = null;
			this.pbCards.Location = new System.Drawing.Point(9, 38);
			this.pbCards.Name = "pbCards";
			this.pbCards.Size = new System.Drawing.Size(202, 127);
			this.pbCards.TabIndex = 38;
			this.pbCards.TabStop = false;
			// 
			// assCardHost
			// 
			this.assCardHost.BackColor = System.Drawing.Color.White;
			this.assCardHost.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.assCardHost.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.assCardHost.ForeColor = System.Drawing.Color.Black;
			this.assCardHost.Location = new System.Drawing.Point(14, 258);
			this.assCardHost.Name = "assCardHost";
			this.assCardHost.Size = new System.Drawing.Size(145, 28);
			this.assCardHost.TabIndex = 37;
			this.assCardHost.Text = "Assign card";
			this.assCardHost.UseVisualStyleBackColor = false;
			this.assCardHost.Click += new System.EventHandler(this.AssCardHostClick);
			// 
			// butBackCards
			// 
			this.butBackCards.BackColor = System.Drawing.Color.White;
			this.butBackCards.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.butBackCards.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butBackCards.ForeColor = System.Drawing.Color.Black;
			this.butBackCards.Location = new System.Drawing.Point(297, 258);
			this.butBackCards.Name = "butBackCards";
			this.butBackCards.Size = new System.Drawing.Size(145, 28);
			this.butBackCards.TabIndex = 36;
			this.butBackCards.Text = "Back";
			this.butBackCards.UseVisualStyleBackColor = false;
			this.butBackCards.Click += new System.EventHandler(this.ButBackCardsClick);
			// 
			// guestP
			// 
			this.guestP.BackColor = System.Drawing.Color.White;
			this.guestP.Controls.Add(this.pictureBox3);
			this.guestP.Controls.Add(this.label1);
			this.guestP.Controls.Add(this.comboBox1);
			this.guestP.Controls.Add(this.label2);
			this.guestP.Controls.Add(this.redCardGuest);
			this.guestP.Controls.Add(this.yellowCardGuest);
			this.guestP.Controls.Add(this.pictureBox1);
			this.guestP.Controls.Add(this.assCardGuest);
			this.guestP.Controls.Add(this.button2);
			this.guestP.Location = new System.Drawing.Point(0, 33);
			this.guestP.Name = "guestP";
			this.guestP.Size = new System.Drawing.Size(452, 296);
			this.guestP.TabIndex = 2;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(266, 63);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(158, 141);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 52;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(266, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 23);
			this.label1.TabIndex = 51;
			this.label1.Text = "Choose player";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(266, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(158, 23);
			this.comboBox1.TabIndex = 50;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 23);
			this.label2.TabIndex = 49;
			this.label2.Text = "Choose a card";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// redCardGuest
			// 
			this.redCardGuest.Location = new System.Drawing.Point(157, 171);
			this.redCardGuest.Name = "redCardGuest";
			this.redCardGuest.Size = new System.Drawing.Size(47, 24);
			this.redCardGuest.TabIndex = 48;
			this.redCardGuest.UseVisualStyleBackColor = true;
			this.redCardGuest.CheckedChanged += new System.EventHandler(this.RedCardGuestCheckedChanged);
			// 
			// yellowCardGuest
			// 
			this.yellowCardGuest.Location = new System.Drawing.Point(54, 171);
			this.yellowCardGuest.Name = "yellowCardGuest";
			this.yellowCardGuest.Size = new System.Drawing.Size(38, 24);
			this.yellowCardGuest.TabIndex = 47;
			this.yellowCardGuest.UseVisualStyleBackColor = true;
			this.yellowCardGuest.CheckedChanged += new System.EventHandler(this.YellowCardGuestCheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(9, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(202, 127);
			this.pictureBox1.TabIndex = 46;
			this.pictureBox1.TabStop = false;
			// 
			// assCardGuest
			// 
			this.assCardGuest.BackColor = System.Drawing.Color.White;
			this.assCardGuest.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.assCardGuest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.assCardGuest.ForeColor = System.Drawing.Color.Black;
			this.assCardGuest.Location = new System.Drawing.Point(14, 258);
			this.assCardGuest.Name = "assCardGuest";
			this.assCardGuest.Size = new System.Drawing.Size(145, 28);
			this.assCardGuest.TabIndex = 45;
			this.assCardGuest.Text = "Assign card";
			this.assCardGuest.UseVisualStyleBackColor = false;
			this.assCardGuest.Click += new System.EventHandler(this.AssCardGuestClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(297, 258);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 28);
			this.button2.TabIndex = 44;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Kartoni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(452, 329);
			this.Controls.Add(this.wraperPanel);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Kartoni";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.wraperPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.hostP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCards)).EndInit();
			this.guestP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
