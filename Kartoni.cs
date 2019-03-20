using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni
{
	
	public partial class Kartoni : Form
	{
		public string yellowHost{get;set;}
		public string redHost{get;set;}
		public string yellowGuest{get;set;}
		public string redGuest{get;set;}
		
		public bool ifCheckedYellowHost{get;set;}
		public bool ifCheckedRedHost{get;set;}
		public bool ifCheckedYellowGuest{get;set;}
		public bool ifCheckedRedGuest{get;set;}
		
		string ConnectionString = "Data Source=Baza.db;Version=3";
		public string idUtakmice;
		public Kartoni(string idUtakmice)
		{
			InitializeComponent();
			this.idUtakmice = idUtakmice;
			hostP.Parent = wraperPanel;
			guestP.Parent = wraperPanel;
			hostP.BringToFront();
			string nazivDomacina = StartGame.nazivDomacina;
			set_Domace_Igrace_Kartoni(nazivDomacina);
			string nazivGosta = StartGame.nazivGosta;
			set_Gostujuce_Igrace_Kartoni(nazivGosta);
		}
		void Button3Click(object sender, EventArgs e)
		{
			hostP.BringToFront();
		}
		void Button4Click(object sender, EventArgs e)
		{
			guestP.BringToFront();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void ButBackCardsClick(object sender, EventArgs e)
		{
			this.Close();
		}
		public void set_Domace_Igrace_Kartoni(string naziv){
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11,Slika FROM Tim WHERE Naziv ='" + naziv + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
    						cbPlayers.Items.Add(r.GetValue(0) + ""); 
    						cbPlayers.Items.Add(r.GetValue(1) + ""); 
    						cbPlayers.Items.Add(r.GetValue(2) + ""); 
    						cbPlayers.Items.Add(r.GetValue(3) + ""); 
    						cbPlayers.Items.Add(r.GetValue(4) + ""); 
    						cbPlayers.Items.Add(r.GetValue(5) + ""); 
    						cbPlayers.Items.Add(r.GetValue(6) + ""); 
    						cbPlayers.Items.Add(r.GetValue(7) + ""); 
    						cbPlayers.Items.Add(r.GetValue(8) + ""); 
    						cbPlayers.Items.Add(r.GetValue(9) + ""); 
    						cbPlayers.Items.Add(r.GetValue(10) + "");
							pictureBox2.Image = Image.FromFile(r.GetValue(11) + "");	    						
    					}}}}}
	
		public void set_Gostujuce_Igrace_Kartoni(string naziv){
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11,Slika FROM Tim WHERE Naziv ='" + naziv + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
    						comboBox1.Items.Add(r.GetValue(0) + ""); 
    						comboBox1.Items.Add(r.GetValue(1) + ""); 
    						comboBox1.Items.Add(r.GetValue(2) + ""); 
    						comboBox1.Items.Add(r.GetValue(3) + ""); 
    						comboBox1.Items.Add(r.GetValue(4) + ""); 
    						comboBox1.Items.Add(r.GetValue(5) + ""); 
    						comboBox1.Items.Add(r.GetValue(6) + ""); 
    						comboBox1.Items.Add(r.GetValue(7) + ""); 
    						comboBox1.Items.Add(r.GetValue(8) + ""); 
    						comboBox1.Items.Add(r.GetValue(9) + ""); 
    						comboBox1.Items.Add(r.GetValue(10) + "");
							pictureBox3.Image = Image.FromFile(r.GetValue(11) + "");	    						
    					}}}}}
		void AssCardHostClick(object sender, EventArgs e){
			if(yellowCardHost.Checked == true){
				give_yellow_card_host();
				
			}else if(redCardHost.Checked == true){
				give_red_card_host();
			}
		}
		void AssCardGuestClick(object sender, EventArgs e)
		{
			if(yellowCardGuest.Checked == true){
				give_yellow_card_guest();
			}else if(redCardGuest.Checked == true){
				give_red_card_guest();
				
			}
		}
		void YellowCardHostCheckedChanged(object sender, EventArgs e)
		{
			if(yellowCardHost.Checked == true){
				redCardHost.Checked = false;
			}
		}
		void RedCardHostCheckedChanged(object sender, EventArgs e)
		{
			if(redCardHost.Checked == true){
				yellowCardHost.Checked = false;
			}
		}
		void give_yellow_card_host(){
			if(yellowCardHost.Checked == true && cbPlayers.Text != ""){
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
					String s = @"UPDATE Utakmica SET Zuti_Kartoni = '" + StartGame.yellowCards +"' WHERE idUtakmice = '" + StartGame.idUtakmice + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(s, c)){
        			cmd.ExecuteNonQuery();
    			}}
				
				yellowHost = cbPlayers.Text;
				ifCheckedYellowHost = yellowCardHost.Checked = true;
				StartGame.yellowCards++;
				MessageBox.Show("Yellow card is given to " + cbPlayers.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else{
				MessageBox.Show("You must chose a card and a player!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void give_red_card_host(){
			if(redCardHost.Checked == true && cbPlayers.Text != ""){
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
					String s = @"UPDATE Utakmica SET Crveni_Kartoni = '" + StartGame.redCards +"' WHERE idUtakmice = '" + StartGame.idUtakmice + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(s, c)){
        			cmd.ExecuteNonQuery();
    			}}
				redHost = cbPlayers.Text;
				ifCheckedRedHost = redCardHost.Checked = true;
				StartGame.redCards++;
				MessageBox.Show("Red card is given to " + cbPlayers.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else{
				MessageBox.Show("You must chose a card and a player!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void give_yellow_card_guest(){
			if(yellowCardGuest.Checked == true && comboBox1.Text != ""){
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
					String s = @"UPDATE Utakmica SET Zuti_Kartoni = '" + StartGame.yellowCards +"' WHERE idUtakmice = '" + StartGame.idUtakmice + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(s, c)){
        			cmd.ExecuteNonQuery();
    			}}
				yellowGuest = comboBox1.Text;
				ifCheckedYellowGuest = yellowCardGuest.Checked = true;
				StartGame.yellowCards++;
				MessageBox.Show("Yellow card is given to " + comboBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else{
				MessageBox.Show("You must chose a card and a player!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void give_red_card_guest(){
			if(redCardGuest.Checked == true && comboBox1.Text != ""){
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
					String s = @"UPDATE Utakmica SET Crveni_Kartoni = '" + StartGame.redCards +"' WHERE idUtakmice = '" + StartGame.idUtakmice + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(s, c)){
        			cmd.ExecuteNonQuery();
    			}}
				redGuest = comboBox1.Text;
				ifCheckedRedGuest = redCardGuest.Checked = true;
				StartGame.redCards++;
				MessageBox.Show("Yellow card is given to " + comboBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else{
				MessageBox.Show("You must chose a card and a player!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void YellowCardGuestCheckedChanged(object sender, EventArgs e)
		{
			if(yellowCardGuest.Checked == true){
				redCardGuest.Checked = false;
			}
		}
		void RedCardGuestCheckedChanged(object sender, EventArgs e)
		{
			if(redCardGuest.Checked == true){
				yellowCardGuest.Checked = false;
			}
		}
	}}
