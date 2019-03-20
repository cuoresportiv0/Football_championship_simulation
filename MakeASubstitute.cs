using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni
{
	
	public partial class MakeASubstitute : Form
	{
		string ConnectionString = "Data Source=Baza.db;Version=3";
		
		public string izlaziIzIgre{get;set;}
		public string ulaziUIgru{get;set;}
	
		public MakeASubstitute()
		{
		
			InitializeComponent();
			
		}
		
		void HostBtnClick(object sender, EventArgs e)
		{		firstTeam.Items.Clear();
				reserveTeam.Items.Clear();
				using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11,Rezerva1,Rezerva2,Rezerva3,Rezerva4,Rezerva5,Rezerva6,Rezerva7 FROM Tim WHERE Naziv ='" + StartGame.nazivDomacina + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
    						firstTeam.Items.Add(r.GetValue(0));
    						firstTeam.Items.Add(r.GetValue(1));
    						firstTeam.Items.Add(r.GetValue(2));
    						firstTeam.Items.Add(r.GetValue(3));
    						firstTeam.Items.Add(r.GetValue(4));
    						firstTeam.Items.Add(r.GetValue(5));
    						firstTeam.Items.Add(r.GetValue(6));
    						firstTeam.Items.Add(r.GetValue(7));
    						firstTeam.Items.Add(r.GetValue(8));
    						firstTeam.Items.Add(r.GetValue(9));
    						firstTeam.Items.Add(r.GetValue(10));
    						reserveTeam.Items.Add(r.GetValue(11));
    						reserveTeam.Items.Add(r.GetValue(12));
    						reserveTeam.Items.Add(r.GetValue(13));
    						reserveTeam.Items.Add(r.GetValue(14));
    						reserveTeam.Items.Add(r.GetValue(15));
    						reserveTeam.Items.Add(r.GetValue(16));
    						reserveTeam.Items.Add(r.GetValue(17));
																		}
																	}
    														}
														}
				
			}
		
		
		
		
		
		
		void GstBtnClick(object sender, EventArgs e)
		{
			firstTeam.Items.Clear();
			reserveTeam.Items.Clear();
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				string sql = @"SELECT Igrac1,Igrac2,Igrac3,Igrac4,Igrac5,Igrac6,Igrac7,Igrac8,Igrac9,Igrac10,Igrac11,Rezerva1,Rezerva2,Rezerva3,Rezerva4,Rezerva5,Rezerva6,Rezerva7 FROM Tim WHERE Naziv ='" + StartGame.nazivGosta + "'";
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(sql, c)){
    				using (SQLiteDataReader r = cmd.ExecuteReader()){
    					while(r.Read()){
    						firstTeam.Items.Add(r.GetValue(0));
    						firstTeam.Items.Add(r.GetValue(1));
    						firstTeam.Items.Add(r.GetValue(2));
    						firstTeam.Items.Add(r.GetValue(3));
    						firstTeam.Items.Add(r.GetValue(4));
    						firstTeam.Items.Add(r.GetValue(5));
    						firstTeam.Items.Add(r.GetValue(6));
    						firstTeam.Items.Add(r.GetValue(7));
    						firstTeam.Items.Add(r.GetValue(8));
    						firstTeam.Items.Add(r.GetValue(9));
    						firstTeam.Items.Add(r.GetValue(10));
    						reserveTeam.Items.Add(r.GetValue(11));
    						reserveTeam.Items.Add(r.GetValue(12));
    						reserveTeam.Items.Add(r.GetValue(13));
    						reserveTeam.Items.Add(r.GetValue(14));
    						reserveTeam.Items.Add(r.GetValue(15));
    						reserveTeam.Items.Add(r.GetValue(16));
    						reserveTeam.Items.Add(r.GetValue(17));
				
				
			
			}
			}
    			}
			}
			
		}
		void BackSubstituteClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void SwitchBtnClick(object sender, EventArgs e)
		{
			izlaziIzIgre=firstTeam.Text;
			ulaziUIgru=reserveTeam.Text;
			MessageBox.Show("You made substitution!","",MessageBoxButtons.OK , MessageBoxIcon.Information);
			this.Close();
			
				
			}
		}
	
		
		
		
		
	}
