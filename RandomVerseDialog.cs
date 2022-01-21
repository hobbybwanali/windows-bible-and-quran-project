/*
 * Created by SharpDevelop. Hobby Mwase
 * User: Hobby Mwase
 * Date: 7/24/2021
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnityScriptures
{
	/// <summary>
	/// Description of RandomVerseDialog.
	/// </summary>
	public partial class RandomVerseDialog : Form
	{
		public RandomVerseDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AddVerseVerseDialogBtnClick(object sender, EventArgs e)
		{
			string text = randVerseLabel.Text;
			if (Program.HandleFavourites(FavouriteAction.Add, FavouriteType.Verse, ref text)) {
				MessageBox.Show("Verse added to favourites", "Favourites", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void CopyVerseVerseDialogBtnClick(object sender, EventArgs e)
		{
			string verseToCopy = randVerseLabel.Text;
			if (!string.IsNullOrWhiteSpace(verseToCopy)) {
				Clipboard.SetText(verseToCopy);
				MessageBox.Show("Verse copied to clipboard", "Verse copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
