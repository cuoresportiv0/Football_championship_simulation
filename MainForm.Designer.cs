/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 10/31/2017
 * Time: 6:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GlavniMeni
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button settings;
		private System.Windows.Forms.Button createGame;
		private System.Windows.Forms.Button startGame;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.exit = new System.Windows.Forms.Button();
			this.settings = new System.Windows.Forms.Button();
			this.createGame = new System.Windows.Forms.Button();
			this.startGame = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.exit);
			this.panel1.Controls.Add(this.settings);
			this.panel1.Controls.Add(this.createGame);
			this.panel1.Controls.Add(this.startGame);
			this.panel1.Location = new System.Drawing.Point(367, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 277);
			this.panel1.TabIndex = 1;
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.White;
			this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exit.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.exit.Location = new System.Drawing.Point(32, 183);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(200, 35);
			this.exit.TabIndex = 3;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// settings
			// 
			this.settings.BackColor = System.Drawing.Color.White;
			this.settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
			this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.settings.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.settings.Location = new System.Drawing.Point(32, 142);
			this.settings.Name = "settings";
			this.settings.Size = new System.Drawing.Size(200, 35);
			this.settings.TabIndex = 2;
			this.settings.Text = "About";
			this.settings.UseVisualStyleBackColor = false;
			this.settings.Click += new System.EventHandler(this.SettingsClick);
			// 
			// createGame
			// 
			this.createGame.BackColor = System.Drawing.Color.White;
			this.createGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createGame.BackgroundImage")));
			this.createGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.createGame.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.createGame.Location = new System.Drawing.Point(32, 101);
			this.createGame.Name = "createGame";
			this.createGame.Size = new System.Drawing.Size(200, 35);
			this.createGame.TabIndex = 1;
			this.createGame.Text = "Create Game";
			this.createGame.UseVisualStyleBackColor = false;
			this.createGame.Click += new System.EventHandler(this.CreateTeamClick);
			// 
			// startGame
			// 
			this.startGame.BackColor = System.Drawing.Color.White;
			this.startGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startGame.BackgroundImage")));
			this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startGame.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.startGame.Location = new System.Drawing.Point(32, 60);
			this.startGame.Name = "startGame";
			this.startGame.Size = new System.Drawing.Size(200, 35);
			this.startGame.TabIndex = 0;
			this.startGame.Text = "Start Game";
			this.startGame.UseVisualStyleBackColor = false;
			this.startGame.Click += new System.EventHandler(this.StartGameClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
