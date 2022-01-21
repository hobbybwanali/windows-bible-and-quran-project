/*
 * Created by SharpDevelop. Hobby Mwase
 * User: Hobby Mwase
 * Date: 7/13/2021
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using AllScripture;
using System.Threading;
using Microsoft.Win32;

namespace UnityScriptures
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Scripture OpenScripture = null;
		string nameOfBookOrChapter = null;
		string countBooksOrChaptersFrom = null;
		Thread searchThread;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//Note: all initial values are updated in the constructor
			
			//updates the favourites
			favouritesComboBox.DataSource = new string[] {
				"Favourite Verses",
				"Favourite Chapters"
			};
			RefreshFavourites(0);
			
			//UPDATE THE UI WITH THE SETTINGS
			//update fonts
			UpdateFonts();
			
			//update the check boxes
			switch (Properties.UScriptureSettings.Default.LaunchOnStart) {
				case false:
					launchOnstartCheckBox.Checked = false;
					break;
				case true:
					launchOnstartCheckBox.Checked = true;
					break;
			}
		}
		//
		void UpdateLabels()
		{
			scriptureNameLabel.Text = OpenScripture.SelectedScripture;
			
			// Bible: count books, Quran: count Sura's
			// Bible: books are read, Quran Sura's are read
			switch (OpenScripture.SelectedScripture) {
				case "Bible":
					countBooksOrChaptersFrom = Scripture.BibleBooks.Length.ToString();
					nameOfBookOrChapter = OpenScripture.SelectedBookName;
					break;
				case "Quran":
					countBooksOrChaptersFrom = Scripture.QuranSuraNames.Length.ToString();
					nameOfBookOrChapter = Scripture.QuranSuraNames[OpenScripture.ActiveChapterNumber];
					break;
			}
			
			if (!string.IsNullOrEmpty(OpenScripture.SelectedBookName)) {
				// book opened? show deatils about the open book
				minDetailLabel.Text = String.Concat(
					"Reading : ", nameOfBookOrChapter.ToUpper(), "\n",
					OpenScripture.ChapterId + ": ", OpenScripture.ActiveChapterNumber + 1, " of ",
					OpenScripture.ActiveNumberOfChapters, 
					" | Verse: ", OpenScripture.ActiveVerseNumber + 1, " to ",
					OpenScripture.ActiveNumberOfVerses
				);
			} else {
				// scripture selected? book not opened yet? deatils about scripture
				minDetailLabel.Text = "Select a book to start reading the scriptures";
			}
		}
		/// <summary>
		/// Updates Every Text on the user interface
		/// </summary>
		void UpdateTexts()
		{
			readerRichTextBox.Text = OpenScripture.ActiveChapterText;
			UpdateLabels();
		}
		/// <summary>
		/// update chapters and verses combobox
		/// </summary>
		void UpdateChaptersAndVerses()
		{

			try {
				//create an array of chapters
				int numberOfChapters = OpenScripture.ActiveChaptersArray.Length;
				string[] chapterNames = new string[numberOfChapters];
				for (int i = 0; i < numberOfChapters; i++) {
					chapterNames[i] = OpenScripture.ChapterId + " " + (i + 1);
				}
				chapterComboBox.DataSource = chapterNames;
				/*chapterComboBox.DataSource = OpenScripture.ActiveChaptersArray.Select(x => {
					return OpenScripture.ChapterId + " " + (OpenScripture.ActiveChaptersArray.ToList().IndexOf(x) + 1);
				}
				).ToArray();*/
				
			} catch (Exception except) {
				MessageBox.Show("Sorry, failed to show the selected Chapter," +
				"				                something went wrong:\n " + except);
			}
			UpdateVerses();
		}
		/// <summary>
		/// Update the verses combobox only
		/// </summary>
		void UpdateVerses()
		{
			try {
				//create an array of verses
				int numberOfVerses = OpenScripture.ActiveVersesArray.Length;
				string[] verseNames = new string[numberOfVerses];
				for (int i = 0; i < numberOfVerses; i++) {
					verseNames[i] = "verse " + " " + (i + 1);
				}
				verseComboBox.DataSource = verseNames;
				/*verseComboBox.DataSource = OpenScripture.ActiveVersesArray.Select(x => {
					return "verse " + (OpenScripture.ActiveVersesArray.ToList().IndexOf(x) + 1);
				}
				).ToArray();*/
				
			} catch (Exception except) {
				MessageBox.Show("Sorry, failed to show the selected verse," +
				"				                Something went wrong:\n " + except);
			}
		}
		/// <summary>
		/// Opens a scripture
		/// </summary>
		/// <param name="scripture">scripture name</param>
		/// <param name="booksToOpen">book names string array</param>
		void GoToScripture(ScriptureName scripture, String[] booksToOpen)
		{
			OpenScripture = new Scripture(scripture);
			bookComboBox.DataSource = booksToOpen;//OpenScripture.BookNames;//add books
			OpenScripture.OpenBook(booksToOpen[0]);//initial book
			bookComboBox.SelectedIndex = 0;// OpenScripture.BookNames.ToList().IndexOf(booksToOpen[0]);
			UpdateTexts();
			UpdateChaptersAndVerses();
		}
		/// <summary>
		/// Navigates to a page
		/// </summary>
		/// <param name="pageName">name of the page panel/control</param>
		void GotoPage(Control pageName)
		{
			List<Control> pages = new List<Control> {
				startPage,
				scriptureReadingPage,
				settingsTabControl
			};
			foreach (var page in pages) {
				page.Visible = page == pageName ? true : false;
			}
			if (pageName == scriptureReadingPage && OpenScripture == null) {
				GoToScripture(ScriptureName.Bible, Scripture.BibleBooks);
			}
		}
		/// <summary>
		/// Opens the RandomVerse dialog
		/// </summary>
		/// <param name="verseText"></param>
		void ShowVerseDialog(string verseText)
		{
			RandomVerseDialog ramdomVerseDialog = new RandomVerseDialog();
			ramdomVerseDialog.randVerseLabel.Text = verseText;
			ramdomVerseDialog.ShowDialog();
		}
		/// <summary>
		/// updates items in the favourites
		/// </summary>
		void RefreshFavourites(int selectedIndex)
		{
			try {
				favouritesComboBox.SelectedIndex = selectedIndex;
			} catch (Exception) {
			}
			//assign the initial source of favourites
			var favouritesSource = favouritesComboBox.SelectedItem.ToString() == "Favourite Verses" ?
				Properties.UScriptureSettings.Default.FavouriteVerses :
				Properties.UScriptureSettings.Default.FavouriteChapters;
			
			favouritesLabel.Text = favouritesComboBox.SelectedItem.ToString();
			//add the favourites to the list
			favouritesListBox.Items.Clear();
			foreach (var favourite in favouritesSource) {
				favouritesListBox.Items.Add(favourite);
			}
		}
		/// <summary>
		/// Updates the fonts
		/// </summary>
		void UpdateFonts()
		{
			readerRichTextBox.Font = Properties.UScriptureSettings.Default.Font;
			fontSampleLabel.Font = Properties.UScriptureSettings.Default.Font;
			fontDialog.Font = Properties.UScriptureSettings.Default.Font;
		}
		
		//IDE defined functions
		//combobox functions
		void BookComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			OpenScripture.OpenBook(bookComboBox.SelectedItem.ToString());
			UpdateChaptersAndVerses();
			UpdateTexts();
		}
		void ChapterComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			OpenScripture.GoToChapter(chapterComboBox.SelectedIndex);
			UpdateVerses();
			UpdateTexts();
		}
		void VerseComboBoxSelectionChangeCommitted(object sender, EventArgs e)
		{
			OpenScripture.GoToVerse(verseComboBox.SelectedIndex);
			readerRichTextBox.Text = OpenScripture.ActiveVerseText;
			UpdateLabels();
		}
		// startpage buttons functions
		void StartPgBibleBtnClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Bible, Scripture.BibleBooks);
		}
		void StartPgQuranBtnClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Quran, Scripture.QuranBooks);
		}
		
		// GO TO:menu toolstrip button functions
		void BibleToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Bible, Scripture.BibleBooks);
		}
		void NewTestamentToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Bible, Scripture.NewTestamentBibleBooks);
		}
		void OldTestamentToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Bible, Scripture.OldTestamentBibleBooks);
		}
		void QuranToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
			GoToScripture(ScriptureName.Quran, Scripture.QuranBooks);
		}
		void StartPageToolStripMenuItem1Click(object sender, EventArgs e)
		{
			GotoPage(startPage);
		}
		void ScriptureReadingToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(scriptureReadingPage);
		}
		void OptionsToolStripMenuItemClick(object sender, EventArgs e)
		{
			GotoPage(settingsTabControl);
		}
		// TOOLS: Menu toolstrip button functions
		void ReadingPlanToolStripMenuItemClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = readingPlanTabPage;
			GotoPage(settingsTabControl);
		}
		void NotesToolStripMenuItemClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = notesTabPage;
			GotoPage(settingsTabControl);
		}
		void FavouritesToolStripMenuItemClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = favouritesTabPage;
			GotoPage(settingsTabControl);
		}
		void BasicInfoToolStripMenuItemClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = basicInfoTabPage;
			GotoPage(settingsTabControl);
		}
		void MoreToolsToolStripMenuItemClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = readingPlanTabPage;
			GotoPage(settingsTabControl);
		}
		//other toolstrip buttons click functions
		void SearchToolStripButtonClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = searchTabPage;
			GotoPage(settingsTabControl);
		}
		void SettingsToolStripButtonClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = settingsTabPage;
			GotoPage(settingsTabControl);
		}
		void InfoToolStripButtonClick(object sender, EventArgs e)
		{
			settingsTabControl.SelectedTab = aboutUsTabPage;
			GotoPage(settingsTabControl);
		}
		void ExitToolStripButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// Random verse buttons
		void RandomBookToolStripMenuItemClick(object sender, EventArgs e)
		{
			ShowVerseDialog(new RandomVerse(RandomVerseSource.Bible).GetRandomVerse());
		}
		void BookOfProverbsToolStripMenuItemClick(object sender, EventArgs e)
		{
			ShowVerseDialog(new RandomVerse(RandomVerseSource.BibleProverbs).GetRandomVerse());
		}
		void BookOfPsalmsToolStripMenuItemClick(object sender, EventArgs e)
		{
			ShowVerseDialog(new RandomVerse(RandomVerseSource.BiblePsalms).GetRandomVerse());
		}
		void QuranToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ShowVerseDialog(new RandomVerse(RandomVerseSource.Quran).GetRandomVerse());
		}
		// functions at the search panel
		void SpecificBookSearchRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			//add booknames to specific book search
			specificBookSearchComboBox.DataSource = specificBookSearchRadioButton.Checked ? Scripture.BibleBooks : null;	
		}
		void NewSearchButtonClick(object sender, EventArgs e)
		{
			searchResultsPanel.Visible = false;
		}
		void SearchButtonClick(object sender, EventArgs e)
		{
			try {
				
				string searchWord = searchTextBox.Text.Trim();
				Scripture scriptureToSearchFrom = null;
				string[] booksToserachFrom = null;
			
				if (!string.IsNullOrWhiteSpace(searchWord) && !string.IsNullOrEmpty(searchWord)) {
					if (bibleRadioButton.Checked) {
						scriptureToSearchFrom = new Scripture(ScriptureName.Bible);
						//assign the books to search from the scripture
						if (OTRadioButton.Checked) {
							booksToserachFrom = Scripture.OldTestamentBibleBooks;
						} else if (NTRadioButton.Checked) {
							booksToserachFrom = Scripture.NewTestamentBibleBooks;
						} else if (specificBookSearchRadioButton.Checked) {
							booksToserachFrom = new []{ specificBookSearchComboBox.SelectedItem.ToString() };
						} else {
							booksToserachFrom = scriptureToSearchFrom.BookNames;
						}
					} else if (QuranRadioButton.Checked) {
						scriptureToSearchFrom = new Scripture(ScriptureName.Quran);
						booksToserachFrom = scriptureToSearchFrom.BookNames;
					}
				
					// make visible the results area and show the found results
					searchResultsPanel.Visible = true;
					searchResultsRichTextBox.Text = "searching...";
				
					//show results and highlight text in a new thread
					searchThread = new Thread(() => {
						searchResultsRichTextBox.Text = scriptureToSearchFrom.SearchScriptures(ref searchWord, ref booksToserachFrom);
						try {
							int wordIndex = searchResultsRichTextBox.Text.IndexOf(searchWord, StringComparison.CurrentCultureIgnoreCase);
							while (wordIndex != -1) {
								searchResultsRichTextBox.SelectionStart = wordIndex;
								searchResultsRichTextBox.SelectionLength = searchWord.Length;
								searchResultsRichTextBox.SelectionColor = Color.Black;
								searchResultsRichTextBox.SelectionBackColor = Color.LightBlue;
								wordIndex = searchResultsRichTextBox.Text.IndexOf(searchWord, wordIndex + 1, StringComparison.CurrentCultureIgnoreCase);
							}
						
						} catch (Exception) {	
						}
					});
					searchThread.Start();
			
				} else {
					MessageBox.Show("Please provide a word to be searched!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}	
			} catch (Exception) {
			}			
		}
		void SearchTextBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			//when user pressess enter on search call the search button event
			if (e.KeyChar == (char)Keys.Enter) {
				try {		
					searchButton.PerformClick();
				} catch (Exception) {
				}
			}
		}
		void PreviousSearchButtonClick(object sender, EventArgs e)
		{
			searchResultsPanel.Visible = true;
		}
		// functions for the favourites section
		void FavouritesComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshFavourites(favouritesComboBox.SelectedIndex);
		}
		void RemoveFavouriteClick(object sender, EventArgs e)
		{
			try {
				string text = favouritesListBox.SelectedItem.ToString();
				switch (favouritesComboBox.SelectedIndex) {
					case 0:
						Program.HandleFavourites(FavouriteAction.Remove, FavouriteType.Verse, ref text);
						RefreshFavourites(0);
						break;
					case 1:
						Program.HandleFavourites(FavouriteAction.Remove, FavouriteType.Chapter, ref text);
						RefreshFavourites(1);
						break;
				}				
			} catch (Exception) {
			}

		}
		//adding to favourites
		void VerseToFavouritesToolStripMenuItemClick(object sender, EventArgs e)
		{
			string text = OpenScripture.SelectedBookName + " " + (OpenScripture.ActiveChapterNumber + 1) + " : " + OpenScripture.ActiveVerseText;
			if (Program.HandleFavourites(FavouriteAction.Add, FavouriteType.Verse, ref text)) {
				MessageBox.Show("The Verse was added to your favourites", "Favourites", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			RefreshFavourites(0);
		}
		void AddChapterToFavouritesToolStripMenuItemClick(object sender, EventArgs e)
		{
			string text = OpenScripture.SelectedBookName + " " + OpenScripture.ChapterId + " " + (OpenScripture.ActiveChapterNumber + 1);
			if (Program.HandleFavourites(FavouriteAction.Add, FavouriteType.Chapter, ref text)) {
				MessageBox.Show("The Chapter was added to your favourites", "Favourites", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			RefreshFavourites(1);
		}
		void CopyCurrentVerseToolStripMenuItemClick(object sender, EventArgs e)
		{
			string verseToCopy = OpenScripture.SelectedBookName + " " + (OpenScripture.ActiveChapterNumber + 1) + " : " + OpenScripture.ActiveVerseText;
			if (!string.IsNullOrWhiteSpace(verseToCopy)) {
				Clipboard.SetText(verseToCopy);
				MessageBox.Show("Verse copied to clipboard", "Verse copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}	
		}
		
		// settings
		void ChangeFontButtonClick(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog() == DialogResult.OK) {
				Properties.UScriptureSettings.Default.Font = fontDialog.Font;
				Properties.UScriptureSettings.Default.Save();
				UpdateFonts();
			}
		}
		void LaunchOnstartCheckBoxCheckStateChanged(object sender, EventArgs e)
		{
			RegistryKey registryLaunchOnStartKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
			CheckState launchingOnStart = launchOnstartCheckBox.CheckState;
			switch (launchingOnStart) {
				case CheckState.Checked:
					registryLaunchOnStartKey.SetValue(Application.ProductName, Application.ExecutablePath);
					Properties.UScriptureSettings.Default.LaunchOnStart = true;
					break;
				case CheckState.Unchecked:
					registryLaunchOnStartKey.DeleteValue(Application.ProductName);
					Properties.UScriptureSettings.Default.LaunchOnStart = false;
					break;
			}
			Properties.UScriptureSettings.Default.Save();
		}
		//linklabel clicked
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Change the color if needed.
			e.Link.Visited = true;
			// Use the Process.Start method to open the default browser with a URL.
			try {	
				System.Diagnostics.Process.Start("https://hobbybwanali@gmail.com");
			} catch (Exception) {
				
			}
		}
		void MinimizeToolStripButtonClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		
		
	}
}
