using System;
using System.Drawing;
using System.Windows.Forms;

namespace GlavniMeni
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();

		}
		void BackClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void StngsBtn1Click(object sender, EventArgs e)
		{
		MessageBox.Show("This is application created on third year of studyng at high school in Arandjelovac. " +
			            "Application is written in C# programming language using SharpDevelop IDE. \n" +   
			            "It simulates football macth with capabilites to choose teams which will play the game. " +
			            "Application allows you to see first and reserve players and coach from both of chosen teams. " +
			            "You can change the score using implemented options and follow live informations. "+
			            "Also you can make a substitution in team in which you wish and give the cards to players. " +
			            "There is also a list of football judges who share the justice on that match. \n" +
			            "In setting you can see informations abouth application and who are the Autors. \n" +
			            "Have a nice day! :)"
			           );
			            
		}
		void StngsBtn2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Autors:\n \tVasiljevic Ljubica\n \tJovanovic Mladen\n \tFilipovic Filip");
		}
	}
}
