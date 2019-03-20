/*
 * Created by SharpDevelop.
 * User: User
 * Date: 14-Dec-17
 * Time: 16:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class MakeASubstitute
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button backSubstitute;
		private System.Windows.Forms.ComboBox firstTeam;
		private System.Windows.Forms.ComboBox reserveTeam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button switchBtn;
		private System.Windows.Forms.Button hostBtn;
		private System.Windows.Forms.Button gstBtn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeASubstitute));
			this.backSubstitute = new System.Windows.Forms.Button();
			this.firstTeam = new System.Windows.Forms.ComboBox();
			this.reserveTeam = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.switchBtn = new System.Windows.Forms.Button();
			this.hostBtn = new System.Windows.Forms.Button();
			this.gstBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// backSubstitute
			// 
			this.backSubstitute.BackColor = System.Drawing.Color.White;
			this.backSubstitute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.backSubstitute.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.backSubstitute.ForeColor = System.Drawing.Color.Black;
			this.backSubstitute.Location = new System.Drawing.Point(279, 260);
			this.backSubstitute.Name = "backSubstitute";
			this.backSubstitute.Size = new System.Drawing.Size(145, 28);
			this.backSubstitute.TabIndex = 12;
			this.backSubstitute.Text = "Back";
			this.backSubstitute.UseVisualStyleBackColor = false;
			this.backSubstitute.Click += new System.EventHandler(this.BackSubstituteClick);
			// 
			// firstTeam
			// 
			this.firstTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.firstTeam.FormattingEnabled = true;
			this.firstTeam.Location = new System.Drawing.Point(12, 35);
			this.firstTeam.Name = "firstTeam";
			this.firstTeam.Size = new System.Drawing.Size(150, 21);
			this.firstTeam.TabIndex = 13;
			// 
			// reserveTeam
			// 
			this.reserveTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.reserveTeam.FormattingEnabled = true;
			this.reserveTeam.Location = new System.Drawing.Point(12, 85);
			this.reserveTeam.Name = "reserveTeam";
			this.reserveTeam.Size = new System.Drawing.Size(150, 21);
			this.reserveTeam.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "First Team";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Reserve Team";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// switchBtn
			// 
			this.switchBtn.BackColor = System.Drawing.Color.White;
			this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.switchBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.switchBtn.ForeColor = System.Drawing.Color.Black;
			this.switchBtn.Location = new System.Drawing.Point(12, 260);
			this.switchBtn.Name = "switchBtn";
			this.switchBtn.Size = new System.Drawing.Size(145, 28);
			this.switchBtn.TabIndex = 19;
			this.switchBtn.Text = "Switch";
			this.switchBtn.UseVisualStyleBackColor = false;
			this.switchBtn.Click += new System.EventHandler(this.SwitchBtnClick);
			// 
			// hostBtn
			// 
			this.hostBtn.BackColor = System.Drawing.Color.White;
			this.hostBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hostBtn.Location = new System.Drawing.Point(194, 6);
			this.hostBtn.Name = "hostBtn";
			this.hostBtn.Size = new System.Drawing.Size(96, 27);
			this.hostBtn.TabIndex = 20;
			this.hostBtn.Text = "Host";
			this.hostBtn.UseVisualStyleBackColor = false;
			this.hostBtn.Click += new System.EventHandler(this.HostBtnClick);
			// 
			// gstBtn
			// 
			this.gstBtn.BackColor = System.Drawing.Color.White;
			this.gstBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gstBtn.Location = new System.Drawing.Point(314, 6);
			this.gstBtn.Name = "gstBtn";
			this.gstBtn.Size = new System.Drawing.Size(97, 27);
			this.gstBtn.TabIndex = 21;
			this.gstBtn.Text = "Guest";
			this.gstBtn.UseVisualStyleBackColor = false;
			this.gstBtn.Click += new System.EventHandler(this.GstBtnClick);
			// 
			// MakeASubstitute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(436, 300);
			this.Controls.Add(this.gstBtn);
			this.Controls.Add(this.hostBtn);
			this.Controls.Add(this.switchBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reserveTeam);
			this.Controls.Add(this.firstTeam);
			this.Controls.Add(this.backSubstitute);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MakeASubstitute";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}
	}
}
