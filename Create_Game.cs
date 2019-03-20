using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni
{
	public partial class Create_Game : Form
	{
		SQLiteConnection konekcija;
		public Create_Game()
		{
			InitializeComponent();
			setKonekcija();
			fillTerm();
			
			updateNazivTima();
				}

		void BackClick(object sender, EventArgs e)
		{
			this.Close();
		}
		String getImepoID(int id){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Naziv FROM Tim WHERE ID_tima = " + id;
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					return r.GetValue(0) + "";
				}
			}
			return "";
			
		}
		String getIDpoImenu(String ime){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT ID_tima FROM Tim WHERE Naziv ='" + ime + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					return r.GetValue(0) + "";
				}
			}
			return "";
		}
		String getPicturePoNaziv(string naziv){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Slika FROM Tim WHERE Naziv ='" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					pictureBox1.Image = Image.FromFile(r.GetValue(0) + "");
				}
			}
			return "";
		}
		String getPicturePoNaziv2(string naziv){

			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Slika FROM Tim WHERE Naziv ='" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					pictureBox2.Image = Image.FromFile(r.GetValue(0) + "");
				}
			}
			return "";
		}
		void SaveClick(object sender, EventArgs e)
		{
			if(hostBox.Items.Contains(hostBox.Text) && guestBox.Items.Contains(guestBox.Text) && hostBox.Text != "" && guestBox.Text != "" && terminBox.Text != ""){
				MessageBox.Show("You created game between " + hostBox.Text + " and " + guestBox.Text
				                , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				string hostName = hostBox.Text;
				string guestName = guestBox.Text;
				string termin = terminBox.Text;
	
				String sql = "insert into Utakmica(idDomacina, idGosta, Termin) values ('" +hostName+ "', '" +guestName+ "', '" +termin+ "')";
				SQLiteCommand komanda = new SQLiteCommand(sql, konekcija);
				komanda.ExecuteNonQuery();
				
				using(SQLiteCommand kkomanda = konekcija.CreateCommand()){
				kkomanda.CommandText = @"UPDATE Termini SET Termin = 0 WHERE idTermina = '"+ terminBox.Text +"'";
				SQLiteDataReader r = kkomanda.ExecuteReader();
			
				terminBox.Items.Remove(terminBox.Text);
				resetTextAndPictures();
				
				}}
			else{
				MessageBox.Show("Error!" ,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		void ResetClick(object sender, EventArgs e){
			
			if(MessageBox.Show("By clicking reset button you will delete hole history of games that are created!", "Alert" ,
			   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK){
				
				String sql = "DELETE FROM Utakmica";
				SQLiteCommand komanda = new SQLiteCommand(sql, konekcija);
				komanda.ExecuteNonQuery();
			}
			// set all to zero
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"UPDATE Termini SET Termin = 0";
				SQLiteDataReader r = komanda.ExecuteReader();
			}
			// then, return all values to their original value
			String sq = "DELETE FROM Termini";
				SQLiteCommand ko = new SQLiteCommand(sq, konekcija);
				ko.ExecuteNonQuery();
			for(int i = 1; i <=5; i++){
				String s = "insert into Termini(Termin, idTermina) values ('" +i+ "', '" +i+ "')";
				SQLiteCommand kom = new SQLiteCommand(s, konekcija);
				kom.ExecuteNonQuery();
			}
			
			
			
			terminBox.Items.Clear();
			fillTerm();
			
			resetTextAndPictures();
		}
		
		
		
		
		void HostBoxSelectedIndexChanged(object sender, EventArgs e){
			
			
			
				String naziv = hostBox.Text;
				getPicturePoNaziv(naziv);
			
				using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT Trener,Kapiten,Formacija FROM Tim WHERE Naziv = '" + naziv + "'";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						hostInfo1.Text = r.GetValue(0) + "";
						hostInfo2.Text = r.GetValue(1) + "";
						hostInfo3.Text = r.GetValue(2) + "";
					}
				}
				remove_from_guestBox();
				guestBox.Items.Clear();
				updateNazivGosta(naziv);
			
		}
		void GuestBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			String naziv = guestBox.Text;
			getPicturePoNaziv2(naziv);

			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Trener,Kapiten,Formacija FROM Tim WHERE Naziv = '" + naziv + "'";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){
					guestInfo1.Text = r.GetValue(0) + "";
					guestInfo2.Text = r.GetValue(1) + "";
					guestInfo3.Text = r.GetValue(2) + "";
				}
			}
			remove_from_hostBox();
			hostBox.Items.Clear();
			updateNazivDomacina(naziv);
		}
		
		public void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=Baza.db;Version=3");
			konekcija.Open();
		}
		public void updateNazivTima(){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT Naziv From Tim";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						hostBox.Items.Add(r.GetValue(0) + "");
						guestBox.Items.Add(r.GetValue(0) + "");
				}
			}
		}
		
		
		
		public void updateNazivGosta(string nazivTima){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT Naziv From Tim Where Naziv != '" + nazivTima + "'";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						guestBox.Items.Add(r.GetValue(0) + "");
				}
			}
		}
		public void updateNazivDomacina(string nazivTima){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT Naziv From Tim Where Naziv != '" + nazivTima + "'";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						hostBox.Items.Add(r.GetValue(0) + "");
				}
			}
		}
		
		void remove_from_guestBox(){
			guestBox.Items.Remove(hostBox.SelectedItem);
		}
		void remove_from_hostBox(){
			hostBox.Items.Remove(guestBox.SelectedItem);
		}
		void fillTerm(){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				komanda.CommandText = @"SELECT Termin From Termini WHERE Termin != 0";
				SQLiteDataReader r = komanda.ExecuteReader();
				while(r.Read()){	
						terminBox.Items.Add(r.GetValue(0) + "");
				}
			}
		}
		void resetTextAndPictures(){
			terminBox.ResetText();
			hostBox.ResetText();
			guestBox.ResetText();
			hostInfo1.ResetText();
			hostInfo2.ResetText();
			hostInfo3.ResetText();
			guestInfo1.ResetText();
			guestInfo2.ResetText();
			guestInfo3.ResetText();
			pictureBox1.Image = null;
			pictureBox2.Image = null;
			
		}

			}}
	
