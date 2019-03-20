/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 10/31/2017
 * Time: 7:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class Settings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button backSettings;
		private System.Windows.Forms.Button stngsBtn1;
		private System.Windows.Forms.Button stngsBtn2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.backSettings = new System.Windows.Forms.Button();
			this.stngsBtn1 = new System.Windows.Forms.Button();
			this.stngsBtn2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// backSettings
			// 
			this.backSettings.BackColor = System.Drawing.Color.White;
			this.backSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.backSettings.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.backSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backSettings.Location = new System.Drawing.Point(480, 380);
			this.backSettings.Name = "backSettings";
			this.backSettings.Size = new System.Drawing.Size(113, 31);
			this.backSettings.TabIndex = 11;
			this.backSettings.Text = "Back";
			this.backSettings.UseVisualStyleBackColor = false;
			this.backSettings.Click += new System.EventHandler(this.BackClick);
			// 
			// stngsBtn1
			// 
			this.stngsBtn1.BackColor = System.Drawing.Color.White;
			this.stngsBtn1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stngsBtn1.Location = new System.Drawing.Point(219, 113);
			this.stngsBtn1.Name = "stngsBtn1";
			this.stngsBtn1.Size = new System.Drawing.Size(212, 29);
			this.stngsBtn1.TabIndex = 12;
			this.stngsBtn1.Text = "About Application";
			this.stngsBtn1.UseVisualStyleBackColor = false;
			this.stngsBtn1.Click += new System.EventHandler(this.StngsBtn1Click);
			// 
			// stngsBtn2
			// 
			this.stngsBtn2.BackColor = System.Drawing.Color.White;
			this.stngsBtn2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stngsBtn2.Location = new System.Drawing.Point(219, 178);
			this.stngsBtn2.Name = "stngsBtn2";
			this.stngsBtn2.Size = new System.Drawing.Size(212, 31);
			this.stngsBtn2.TabIndex = 13;
			this.stngsBtn2.Text = "Autors";
			this.stngsBtn2.UseVisualStyleBackColor = false;
			this.stngsBtn2.Click += new System.EventHandler(this.StngsBtn2Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.stngsBtn2);
			this.Controls.Add(this.stngsBtn1);
			this.Controls.Add(this.backSettings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Settings";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}
	}
}
