using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni
{
	public partial class Judges : Form
	{
		SQLiteConnection konekcija;
		public Judges()
		{
			InitializeComponent();									
			setKonekcija();
			
			setJudges(StartGame.idSudije);
	
		}
		void BackClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		public void setJudges(string naziv){
			
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Sudija1,Sudija2,Sudija3 FROM Sudije WHERE idSudije ='" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					tbFjudge.Text = r.GetValue(0) + "";
					tbSjudge.Text = r.GetValue(1) + "";
					tbTjudge.Text = r.GetValue(2) + "";
				}
				
			}
		}
		public void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=Baza.db;Version=3");
			konekcija.Open();
		}
	}
}
