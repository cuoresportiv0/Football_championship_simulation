/*
 * Created by SharpDevelop.
 * User: User
 * Date: 13-Dec-17
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class Judges
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbFjudge;
		private System.Windows.Forms.TextBox tbSjudge;
		private System.Windows.Forms.TextBox tbTjudge;
		private System.Windows.Forms.Label fJudge;
		private System.Windows.Forms.Label sJudge;
		private System.Windows.Forms.Label tJudge;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Judges));
			this.tbFjudge = new System.Windows.Forms.TextBox();
			this.tbSjudge = new System.Windows.Forms.TextBox();
			this.tbTjudge = new System.Windows.Forms.TextBox();
			this.fJudge = new System.Windows.Forms.Label();
			this.sJudge = new System.Windows.Forms.Label();
			this.tJudge = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbFjudge
			// 
			this.tbFjudge.Location = new System.Drawing.Point(234, 119);
			this.tbFjudge.Name = "tbFjudge";
			this.tbFjudge.ReadOnly = true;
			this.tbFjudge.Size = new System.Drawing.Size(196, 23);
			this.tbFjudge.TabIndex = 0;
			// 
			// tbSjudge
			// 
			this.tbSjudge.Location = new System.Drawing.Point(234, 171);
			this.tbSjudge.Name = "tbSjudge";
			this.tbSjudge.ReadOnly = true;
			this.tbSjudge.Size = new System.Drawing.Size(196, 23);
			this.tbSjudge.TabIndex = 1;
			// 
			// tbTjudge
			// 
			this.tbTjudge.Location = new System.Drawing.Point(234, 223);
			this.tbTjudge.Name = "tbTjudge";
			this.tbTjudge.ReadOnly = true;
			this.tbTjudge.Size = new System.Drawing.Size(196, 23);
			this.tbTjudge.TabIndex = 2;
			// 
			// fJudge
			// 
			this.fJudge.BackColor = System.Drawing.Color.Transparent;
			this.fJudge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fJudge.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fJudge.ForeColor = System.Drawing.Color.White;
			this.fJudge.Location = new System.Drawing.Point(295, 93);
			this.fJudge.Name = "fJudge";
			this.fJudge.Size = new System.Drawing.Size(135, 23);
			this.fJudge.TabIndex = 3;
			this.fJudge.Text = "First judge";
			this.fJudge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sJudge
			// 
			this.sJudge.BackColor = System.Drawing.Color.Transparent;
			this.sJudge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sJudge.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sJudge.ForeColor = System.Drawing.Color.White;
			this.sJudge.Location = new System.Drawing.Point(295, 145);
			this.sJudge.Name = "sJudge";
			this.sJudge.Size = new System.Drawing.Size(135, 23);
			this.sJudge.TabIndex = 4;
			this.sJudge.Text = "Second judge";
			this.sJudge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tJudge
			// 
			this.tJudge.BackColor = System.Drawing.Color.Transparent;
			this.tJudge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tJudge.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tJudge.ForeColor = System.Drawing.Color.White;
			this.tJudge.Location = new System.Drawing.Point(295, 197);
			this.tJudge.Name = "tJudge";
			this.tJudge.Size = new System.Drawing.Size(135, 23);
			this.tJudge.TabIndex = 5;
			this.tJudge.Text = "Third judge";
			this.tJudge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.back.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.back.ForeColor = System.Drawing.Color.White;
			this.back.Location = new System.Drawing.Point(12, 252);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(112, 27);
			this.back.TabIndex = 11;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.BackClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(90, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 31);
			this.label1.TabIndex = 12;
			this.label1.Text = "Judges for this match";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Judges
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(442, 291);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.tJudge);
			this.Controls.Add(this.sJudge);
			this.Controls.Add(this.fJudge);
			this.Controls.Add(this.tbTjudge);
			this.Controls.Add(this.tbSjudge);
			this.Controls.Add(this.tbFjudge);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Judges";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
