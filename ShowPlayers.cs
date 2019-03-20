using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni{
	public partial class ShowPlayers : Form{
		
		SQLiteConnection konekcija;
		public ShowPlayers(){
			setKonekcija();
			InitializeComponent();
			
			setHost(StartGame.nazivDomacina);
			setGuest(StartGame.nazivGosta);
			
			
		}
		
		void BackClick(object sender, EventArgs e)
		{
			hostPanel.BringToFront();		
		}
		void NextClick(object sender, EventArgs e)
		{
			guestPanel.BringToFront();
		}
		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void setHost(string naziv){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Trener, Rezerva1,Rezerva2,Rezerva3,Rezerva4,Rezerva5,Rezerva6,Rezerva7,Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11 FROM Tim WHERE Naziv ='" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					coach1tb.Text = r.GetValue(0) + "";
					rezerva1.Text = r.GetValue(1) + "";
					rezerva2.Text = r.GetValue(2) + "";
					rezerva3.Text = r.GetValue(3) + "";
					rezerva4.Text = r.GetValue(4) + "";
					rezerva5.Text = r.GetValue(5) + "";
					rezerva6.Text = r.GetValue(6) + "";
					rezerva7.Text = r.GetValue(7) + "";
					igrac1.Text = r.GetValue(8) + "";
					igrac2.Text = r.GetValue(9) + "";
					igrac3.Text = r.GetValue(10) + "";
					igrac4.Text = r.GetValue(11) + "";
					igrac5.Text = r.GetValue(12) + "";
					igrac6.Text = r.GetValue(13) + "";
					igrac7.Text = r.GetValue(14) + "";
					igrac8.Text = r.GetValue(15) + "";
					igrac9.Text = r.GetValue(16) + "";
					igrac10.Text = r.GetValue(17) + "";
					igrac11.Text = r.GetValue(18) + "";
					
				}
				
			}
		}
		public void setGuest(string naziv){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Trener,Rezerva1,Rezerva2,Rezerva3,Rezerva4,Rezerva5,Rezerva6,Rezerva7,Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11 FROM Tim WHERE Naziv ='" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					coach2tb.Text = r.GetValue(0) + "";
					rez1.Text = r.GetValue(1) + "";
					rez2.Text = r.GetValue(2) + "";
					rez3.Text = r.GetValue(3) + "";
					rez4.Text = r.GetValue(4) + "";
					rez5.Text = r.GetValue(5) + "";
					rez6.Text = r.GetValue(6) + "";
					rez7.Text = r.GetValue(7) + "";
					igr1.Text = r.GetValue(8) + "";
					igr2.Text = r.GetValue(9) + "";
					igr3.Text = r.GetValue(10) + "";
					igr4.Text = r.GetValue(11) + "";
					igr5.Text = r.GetValue(12) + "";
					igr6.Text = r.GetValue(13) + "";
					igr7.Text = r.GetValue(14) + "";
					igr8.Text = r.GetValue(15) + "";
					igr9.Text = r.GetValue(16) + "";
					igr10.Text = r.GetValue(17) + "";
					igr11.Text = r.GetValue(18) + "";
				}
				
			}
		}
		
		public void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=Baza.db;Version=3");
			konekcija.Open();
		}
		
	}
}

