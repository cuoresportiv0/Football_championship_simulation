using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;


namespace GlavniMeni
{
	public partial class MainForm : Form
	{
		public SQLiteConnection konekcija;
		public MainForm()
		{
			InitializeComponent();
			setKonekcija();
			Play();
			}
		
		
		public void Play(){
			string soundFile=@"music.wav";	
			var sound=new System.Media.SoundPlayer(soundFile);
			sound.PlayLooping();
			
			}
			
			
		
		
			
		
		
		
	
		
	
		
		
		
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			panel1.BackColor = Color.FromArgb(100,0,64,64);
		}
		void ExitClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you really want to exit?", "",
			                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
				this.Close();
			}
		}
		void StartGameClick(object sender, EventArgs e)
		{
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT COUNT(*) FROM Utakmica";
            int result = int.Parse(komanda.ExecuteScalar().ToString());

			if(result >= 1){
				StartGame sg = new StartGame();
				sg.ShowDialog();
			}else{
				MessageBox.Show("You must create game!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			}
		}
	
		
		void CreateTeamClick(object sender, EventArgs e)
		{
			Create_Game cg = new Create_Game();
			cg.ShowDialog();
		}
		void SettingsClick(object sender, EventArgs e)
		{
			Settings stngs = new Settings();
			stngs.ShowDialog();
		}
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=Baza.db;Version=3");
			konekcija.Open();
		}
		
		
	}
	
}
