using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni
{
	public partial class StartGame : Form
	{	
		string ConnectionString = "Data Source=Baza.db;Version=3";
		SQLiteConnection konekcija;
		public static string nazivDomacina;
		public static string nazivGosta;
		public static string idSudije;
		public static string idUtakmice;
		public static int yellowCards = 1;
		public static int redCards = 1;
		
		
		int PW;
		bool Hided;
		
		public StartGame(){
		
			InitializeComponent();

			PW = sPanel.Width;
			Hided = false;

			string id = getId_Utakmice();
			idUtakmice = id;
			string host = getNaziv_fromId_Host(id);
			string guest = getNaziv_fromId_Guest(id);
			nazivDomacina = host;
			nazivGosta = guest;
			
			idSudije = getId_Sudije();
			
			setHost(host);
			setGuest(guest);
			Live_Informations.Items.Add(" - The game started - ");
		}
		//Generisani nasumicni brojevi
		public string getId_Utakmice(){
			
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT idUtakmice FROM Utakmica ORDER BY RANDOM() LIMIT 1";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						string s = r.GetValue(0) + "";
						return s;
				}
    					return "";
          
        			}
    			}
			}			
			
		}
		//Metoda za uzimanje imena iz idDomacina preko getid_Utakmice
		public string getNaziv_fromId_Host(String id){
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT idDomacina FROM Utakmica WHERE idUtakmice ='" + id + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						string s = r.GetValue(0) + "";
						return s;
				}
    					return "";
          
        			}
    			}
			}	
		}
		//Metoda za uzimanje imena iz idGosta preko getid_Utakmice
		public string getNaziv_fromId_Guest(String id){
			
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT idGosta FROM Utakmica WHERE idUtakmice ='" + id + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						string s = r.GetValue(0) + "";
						return s;
				}
    					return "";
          
        			}
    			}
			}	
		}
		//domacin
		public void setHost(string naziv){
			
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Slika FROM Tim WHERE Naziv ='" + naziv + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						hostPicture.Image = Image.FromFile(r.GetValue(0) + "");
						domacin.Text = naziv;
				}
    					
        			}
    			}
			}
		}
		//gosta
		public void setGuest(string naziv){
			
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Slika FROM Tim WHERE Naziv ='" + naziv + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						guestPicture.Image = Image.FromFile(r.GetValue(0) + "");
						gost.Text = naziv;
				}
    					
        			}
    			}
			}
		}
		public string getId_Sudije(){
			
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT idSudije FROM Sudije ORDER BY RANDOM() LIMIT 1";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
						string idSudije = r.GetValue(0) + "";
						return idSudije;
				}
    					return "";
        			}
    			}
			}
		}

		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ShowPlayersClick(object sender, EventArgs e)
		{
			ShowPlayers sp = new ShowPlayers();
			sp.ShowDialog();
		}
		void MenuClick(object sender, EventArgs e)
		{
			if(Hided) menu.Text = "H\n\nI\n\nD\n\nE";
			else menu.Text = "M\n\nE\n\nN\n\nU";
			timer1.Start();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(Hided){
				sPanel.Width = sPanel.Width + 10;
				if(sPanel.Width >= PW){
					timer1.Stop();
					Hided = false;
					this.Refresh();
				}
				
			}else{
				sPanel.Width = sPanel.Width - 10;
				if(sPanel.Width <= 0){
					timer1.Stop();
					Hided = true;
					this.Refresh();
				}
			}
		}
		public void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=Baza.db;Version=3");
			konekcija.Open();
		}
		void JudgeBtnClick(object sender, EventArgs e)
		{
			Judges jds = new Judges();
			jds.ShowDialog();
		}
		void CardBtnClick(object sender, EventArgs e)
		{
			Kartoni crd = new Kartoni(idUtakmice);
			crd.ShowDialog();
			if(crd.ifCheckedYellowHost == true){
				Live_Informations.Items.Add(" - Yellow card is given to " + crd.yellowHost + "!");
			}
			if(crd.ifCheckedRedHost == true){
				Live_Informations.Items.Add(" - Red card is given to " + crd.redHost + "!");
			}
			if(crd.ifCheckedYellowGuest == true){
				Live_Informations.Items.Add(" - Yellow card is given to " + crd.yellowGuest + "!");
			}
			if(crd.ifCheckedRedGuest == true){
				Live_Informations.Items.Add(" - Red card is given to " + crd.redGuest + "!");
			}
		}
		void ScoreBtnClick(object sender, EventArgs e)
		{
			ChangeScor cs = new ChangeScor(idUtakmice);
			cs.ShowDialog();
			if (cs.a == null && cs.b == null){
				result1.Text = "0";
				result2.Text = "0";
				
				int n1 = int.Parse(result1.Text);
				int n2 = int.Parse(result2.Text);
				
				if(n1 > n2){
					Live_Informations.Items.Add(" - " + domacin.Text + " is leading the game!");
				}
				else if(n1 < n2){
					Live_Informations.Items.Add(" - " + gost.Text + " is leading the game!");
				}
				else{
					Live_Informations.Items.Add(" - The game is equal!");
				}
			}
			else{
				result1.Text = cs.a;
				result2.Text = cs.b;
				
				int n1 = int.Parse(result1.Text);
				int n2 = int.Parse(result2.Text);
				
				if(n1 > n2){
					Live_Informations.Items.Add(" - " + domacin.Text + " is leading the game!");
				}
				else if(n1 < n2){
					Live_Informations.Items.Add(" - " + gost.Text + " is leading the game!");
				}
				else{
					Live_Informations.Items.Add(" - The game is equal!");
				}
			}
		}
		void SubsBtnClick(object sender, EventArgs e)
		{
			MakeASubstitute ms = new MakeASubstitute();
			ms.ShowDialog();
			Live_Informations.Items.Add("- Substitution --->>> Out: "+ms.izlaziIzIgre);
			Live_Informations.Items.Add("- Substitution --->>> In game: "+ms.ulaziUIgru);
		}
	}
}
