/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/5/2017
 * Time: 6:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class Create_Game
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox hostBox;
		private System.Windows.Forms.ComboBox guestBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label domacin;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox hostInfo1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox hostInfo3;
		private System.Windows.Forms.TextBox hostInfo2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox guestInfo3;
		private System.Windows.Forms.TextBox guestInfo2;
		private System.Windows.Forms.TextBox guestInfo1;
		private System.Windows.Forms.Label termin;
		private System.Windows.Forms.ComboBox terminBox;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Game));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.back = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.terminBox = new System.Windows.Forms.ComboBox();
			this.termin = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.guestInfo3 = new System.Windows.Forms.TextBox();
			this.guestInfo2 = new System.Windows.Forms.TextBox();
			this.guestInfo1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.hostInfo3 = new System.Windows.Forms.TextBox();
			this.hostInfo2 = new System.Windows.Forms.TextBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.hostInfo1 = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.domacin = new System.Windows.Forms.Label();
			this.guestBox = new System.Windows.Forms.ComboBox();
			this.hostBox = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 11);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 538);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.back);
			this.panel3.Controls.Add(this.reset);
			this.panel3.Controls.Add(this.save);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(59, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(186, 534);
			this.panel3.TabIndex = 1;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.White;
			this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.back.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.back.Location = new System.Drawing.Point(5, 101);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(176, 35);
			this.back.TabIndex = 10;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.BackClick);
			// 
			// reset
			// 
			this.reset.BackColor = System.Drawing.Color.White;
			this.reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset.BackgroundImage")));
			this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.reset.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.reset.Location = new System.Drawing.Point(5, 60);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(176, 35);
			this.reset.TabIndex = 9;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = false;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// save
			// 
			this.save.BackColor = System.Drawing.Color.White;
			this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
			this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.save.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.save.Location = new System.Drawing.Point(5, 19);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(176, 35);
			this.save.TabIndex = 8;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = false;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(59, 534);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 331);
			this.label1.TabIndex = 0;
			this.label1.Text = "C\r\nr\r\ne\r\na\r\nt\r\ne\r\n\r\nG\r\na\r\nm\r\ne";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.terminBox);
			this.panel4.Controls.Add(this.termin);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.guestInfo3);
			this.panel4.Controls.Add(this.guestInfo2);
			this.panel4.Controls.Add(this.guestInfo1);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.hostInfo3);
			this.panel4.Controls.Add(this.hostInfo2);
			this.panel4.Controls.Add(this.panel10);
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.hostInfo1);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.domacin);
			this.panel4.Controls.Add(this.guestBox);
			this.panel4.Controls.Add(this.hostBox);
			this.panel4.Location = new System.Drawing.Point(268, 11);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(704, 536);
			this.panel4.TabIndex = 1;
			// 
			// terminBox
			// 
			this.terminBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.terminBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.terminBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.terminBox.ForeColor = System.Drawing.Color.Black;
			this.terminBox.FormattingEnabled = true;
			this.terminBox.Location = new System.Drawing.Point(515, 30);
			this.terminBox.Name = "terminBox";
			this.terminBox.Size = new System.Drawing.Size(182, 27);
			this.terminBox.TabIndex = 31;
			// 
			// termin
			// 
			this.termin.BackColor = System.Drawing.Color.DarkSlateGray;
			this.termin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.termin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.termin.ForeColor = System.Drawing.Color.White;
			this.termin.Location = new System.Drawing.Point(562, 5);
			this.termin.Name = "termin";
			this.termin.Size = new System.Drawing.Size(135, 22);
			this.termin.TabIndex = 30;
			this.termin.Text = "Set up Term";
			this.termin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(232, 444);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 22);
			this.label4.TabIndex = 29;
			this.label4.Text = "Formation";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(232, 393);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 22);
			this.label8.TabIndex = 28;
			this.label8.Text = "Captain";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(232, 342);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 22);
			this.label9.TabIndex = 27;
			this.label9.Text = "Coach";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guestInfo3
			// 
			this.guestInfo3.BackColor = System.Drawing.Color.White;
			this.guestInfo3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guestInfo3.Location = new System.Drawing.Point(232, 469);
			this.guestInfo3.Name = "guestInfo3";
			this.guestInfo3.ReadOnly = true;
			this.guestInfo3.Size = new System.Drawing.Size(264, 23);
			this.guestInfo3.TabIndex = 26;
			// 
			// guestInfo2
			// 
			this.guestInfo2.BackColor = System.Drawing.Color.White;
			this.guestInfo2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guestInfo2.Location = new System.Drawing.Point(232, 418);
			this.guestInfo2.Name = "guestInfo2";
			this.guestInfo2.ReadOnly = true;
			this.guestInfo2.Size = new System.Drawing.Size(264, 23);
			this.guestInfo2.TabIndex = 25;
			// 
			// guestInfo1
			// 
			this.guestInfo1.BackColor = System.Drawing.Color.White;
			this.guestInfo1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guestInfo1.Location = new System.Drawing.Point(232, 367);
			this.guestInfo1.Name = "guestInfo1";
			this.guestInfo1.ReadOnly = true;
			this.guestInfo1.Size = new System.Drawing.Size(264, 23);
			this.guestInfo1.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(232, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 22);
			this.label7.TabIndex = 22;
			this.label7.Text = "Formation";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(232, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 22);
			this.label6.TabIndex = 21;
			this.label6.Text = "Captain";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(232, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 22);
			this.label5.TabIndex = 20;
			this.label5.Text = "Coach";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hostInfo3
			// 
			this.hostInfo3.BackColor = System.Drawing.Color.White;
			this.hostInfo3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hostInfo3.Location = new System.Drawing.Point(232, 202);
			this.hostInfo3.Name = "hostInfo3";
			this.hostInfo3.ReadOnly = true;
			this.hostInfo3.Size = new System.Drawing.Size(264, 23);
			this.hostInfo3.TabIndex = 19;
			// 
			// hostInfo2
			// 
			this.hostInfo2.BackColor = System.Drawing.Color.White;
			this.hostInfo2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hostInfo2.Location = new System.Drawing.Point(232, 151);
			this.hostInfo2.Name = "hostInfo2";
			this.hostInfo2.ReadOnly = true;
			this.hostInfo2.Size = new System.Drawing.Size(264, 23);
			this.hostInfo2.TabIndex = 18;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Black;
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel10.Location = new System.Drawing.Point(0, 2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(2, 528);
			this.panel10.TabIndex = 17;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(698, 2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(2, 528);
			this.panel8.TabIndex = 15;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 530);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(700, 2);
			this.panel7.TabIndex = 14;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(700, 2);
			this.panel6.TabIndex = 13;
			// 
			// hostInfo1
			// 
			this.hostInfo1.BackColor = System.Drawing.Color.White;
			this.hostInfo1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hostInfo1.Location = new System.Drawing.Point(232, 100);
			this.hostInfo1.Name = "hostInfo1";
			this.hostInfo1.ReadOnly = true;
			this.hostInfo1.Size = new System.Drawing.Size(264, 23);
			this.hostInfo1.TabIndex = 11;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Location = new System.Drawing.Point(1, 266);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(700, 2);
			this.panel5.TabIndex = 6;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Location = new System.Drawing.Point(8, 342);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 185);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(8, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 185);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "Set up Guest";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// domacin
			// 
			this.domacin.BackColor = System.Drawing.Color.DarkSlateGray;
			this.domacin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.domacin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.domacin.ForeColor = System.Drawing.Color.White;
			this.domacin.Location = new System.Drawing.Point(8, 7);
			this.domacin.Name = "domacin";
			this.domacin.Size = new System.Drawing.Size(216, 33);
			this.domacin.TabIndex = 2;
			this.domacin.Text = "Set up Host";
			this.domacin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guestBox
			// 
			this.guestBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.guestBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guestBox.ForeColor = System.Drawing.Color.Black;
			this.guestBox.FormattingEnabled = true;
			this.guestBox.Location = new System.Drawing.Point(8, 309);
			this.guestBox.Name = "guestBox";
			this.guestBox.Size = new System.Drawing.Size(216, 27);
			this.guestBox.TabIndex = 1;
			this.guestBox.SelectedIndexChanged += new System.EventHandler(this.GuestBoxSelectedIndexChanged);
			// 
			// hostBox
			// 
			this.hostBox.BackColor = System.Drawing.Color.White;
			this.hostBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.hostBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hostBox.ForeColor = System.Drawing.Color.Black;
			this.hostBox.FormattingEnabled = true;
			this.hostBox.Location = new System.Drawing.Point(8, 42);
			this.hostBox.Name = "hostBox";
			this.hostBox.Size = new System.Drawing.Size(216, 27);
			this.hostBox.TabIndex = 0;
			this.hostBox.SelectedIndexChanged += new System.EventHandler(this.HostBoxSelectedIndexChanged);
			// 
			// Create_Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Create_Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
