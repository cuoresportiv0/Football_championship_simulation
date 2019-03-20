/*
 * Created by SharpDevelop.
 * User: User
 * Date: 14-Dec-17
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class ChangeScor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button backScor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbHScore;
		private System.Windows.Forms.TextBox tbGScore;
		private System.Windows.Forms.Label labScore;
		private System.Windows.Forms.Button updateBtn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeScor));
			this.backScor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labScore = new System.Windows.Forms.Label();
			this.tbHScore = new System.Windows.Forms.TextBox();
			this.tbGScore = new System.Windows.Forms.TextBox();
			this.updateBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// backScor
			// 
			this.backScor.BackColor = System.Drawing.Color.White;
			this.backScor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.backScor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.backScor.ForeColor = System.Drawing.Color.Black;
			this.backScor.Location = new System.Drawing.Point(278, 273);
			this.backScor.Name = "backScor";
			this.backScor.Size = new System.Drawing.Size(145, 28);
			this.backScor.TabIndex = 11;
			this.backScor.Text = "Back";
			this.backScor.UseVisualStyleBackColor = false;
			this.backScor.Click += new System.EventHandler(this.BackScorClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Host";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(298, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Guest";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labScore
			// 
			this.labScore.BackColor = System.Drawing.Color.Transparent;
			this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labScore.ForeColor = System.Drawing.Color.White;
			this.labScore.Location = new System.Drawing.Point(6, 9);
			this.labScore.Name = "labScore";
			this.labScore.Size = new System.Drawing.Size(417, 33);
			this.labScore.TabIndex = 14;
			this.labScore.Text = "Change the score";
			this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbHScore
			// 
			this.tbHScore.Location = new System.Drawing.Point(6, 80);
			this.tbHScore.Name = "tbHScore";
			this.tbHScore.Size = new System.Drawing.Size(125, 20);
			this.tbHScore.TabIndex = 15;
			// 
			// tbGScore
			// 
			this.tbGScore.Location = new System.Drawing.Point(298, 80);
			this.tbGScore.Name = "tbGScore";
			this.tbGScore.Size = new System.Drawing.Size(125, 20);
			this.tbGScore.TabIndex = 16;
			// 
			// updateBtn
			// 
			this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.updateBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateBtn.Location = new System.Drawing.Point(6, 273);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(145, 28);
			this.updateBtn.TabIndex = 17;
			this.updateBtn.Text = "Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// ChangeScor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(428, 307);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.tbGScore);
			this.Controls.Add(this.tbHScore);
			this.Controls.Add(this.labScore);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.backScor);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChangeScor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
