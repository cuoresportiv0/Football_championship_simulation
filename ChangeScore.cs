using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlavniMeni{
	public partial class ChangeScor : Form {
		
		string ConnectionString = "Data Source=Baza.db;Version=3";
		string[] nizStringova;
		
		public string a{get;set;}
		public string b{get;set;}
		
		public string idUtakmice;
		public ChangeScor(string idUtakmice){
			InitializeComponent();
			nizStringova = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u", "v","w","x","y","z"};
			this.idUtakmice = idUtakmice;
			
		}
		
		void BackScorClick(object sender, EventArgs e)
		{	
			this.Close();
		}
	
		void UpdateBtnClick(object sender, EventArgs e){
				updateTheScore();
				MessageBox.Show("You have changed the score!","",MessageBoxButtons.OK , MessageBoxIcon.Information);
				this.Close();
		}
		
		void updateTheScore(){
			
			
			
			
			for(int i = 0; i < nizStringova.Length; i++){
				if((tbHScore.Text.ToLower().Contains(nizStringova[i]) && tbGScore.Text.ToLower().Contains(nizStringova[i].ToLower()))
					|| (tbHScore.Text.ToLower().Contains(nizStringova[i]) || tbGScore.Text.ToLower().Contains(nizStringova[i].ToLower()))){
					MessageBox.Show("String entered!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					tbHScore.Text = "0";
					tbGScore.Text = "0";
				}
				else{
					if(tbHScore.Text.Equals(null) && tbGScore.Text.Equals(null)){
						tbHScore.Text = "0";
						tbGScore.Text = "0";
						a=tbHScore.Text;
						b=tbGScore.Text;
					}
					if(tbHScore.Text.Equals("")){
						tbHScore.Text = "0";
						a=tbHScore.Text;
						b=tbGScore.Text;
					}
					if(tbGScore.Text.Equals("")){
						tbGScore.Text = "0";
						a=tbHScore.Text;
						b=tbGScore.Text;
					}
					a=tbHScore.Text;
					b=tbGScore.Text;
				}
		}
			using (SQLiteConnection c = new SQLiteConnection(ConnectionString)){
				String s = @"UPDATE Utakmica SET goloviDomacina = '" + tbHScore.Text + "', goloviGosta = '" + tbGScore.Text + "' WHERE idUtakmice = '" + idUtakmice + "'";				
    			c.Open();
    			using (SQLiteCommand cmd = new SQLiteCommand(s, c)){
        			cmd.ExecuteNonQuery();
    			}
			}
		}	
		}
	}

		
		
	
