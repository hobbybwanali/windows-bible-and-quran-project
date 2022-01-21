/*
 * Created by SharpDevelop. Hobby Mwase
 * User: Hobby Mwase
 * Date: 7/13/2021
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
using System;
namespace UnityScriptures
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton searchToolStripButton;
		private System.Windows.Forms.ToolStripButton infoToolStripButton;
		private System.Windows.Forms.ToolStripDropDownButton randomVerseToolStripButton;
		private System.Windows.Forms.Label minDetailLabel;
		private System.Windows.Forms.ToolStripDropDownButton scriptureSelectionBtn;
		private System.Windows.Forms.ToolStripMenuItem bibleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quranToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton settingsToolStripButton;
		private System.Windows.Forms.ToolStripButton exitToolStripButton;
		private System.Windows.Forms.ComboBox verseComboBox;
		private System.Windows.Forms.ComboBox chapterComboBox;
		private System.Windows.Forms.ComboBox bookComboBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label scriptureNameLabel;
		
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button startPgQuranBtn;
		private System.Windows.Forms.Button startPgBibleBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem startPageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem randomVerseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bibleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem quranToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem readingPlanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem favouriteVersesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bonusInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startPageToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem scriptureReadingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.TabControl settingsTabControl;
		private System.Windows.Forms.TabPage readingPlanTabPage;
		private System.Windows.Forms.TabPage notesTabPage;
		private System.Windows.Forms.TabPage favouritesTabPage;
		private System.Windows.Forms.TabPage searchTabPage;
		private System.Windows.Forms.TabPage aboutUsTabPage;
		private System.Windows.Forms.TabPage basicInfoTabPage;
		private System.Windows.Forms.TabPage settingsTabPage;
		private System.Windows.Forms.GroupBox scriptureReadingPage;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.CheckBox launchOnstartCheckBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripMenuItem newTestamentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oldTestamentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem randomBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookOfProverbsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookOfPsalmsToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem verseToFavouritesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addChapterToFavouritesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyCurrentVerseToolStripMenuItem;
		private System.Windows.Forms.Panel startPage;
		private System.Windows.Forms.RadioButton QuranRadioButton;
		private System.Windows.Forms.RadioButton bibleRadioButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton NTRadioButton;
		private System.Windows.Forms.RadioButton OTRadioButton;
		private System.Windows.Forms.Panel searchResultsPanel;
		private System.Windows.Forms.RichTextBox searchResultsRichTextBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button newSearchButton;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.Button previousSearchButton;
		private System.Windows.Forms.Label favouritesLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox favouritesListBox;
		private System.Windows.Forms.Button removeFavourite;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox favouritesComboBox;
		private System.Windows.Forms.RichTextBox readerRichTextBox;
		private System.Windows.Forms.Label fontSampleLabel;
		private System.Windows.Forms.Button changeFontButton;
		private System.Windows.Forms.ComboBox specificBookSearchComboBox;
		private System.Windows.Forms.RadioButton specificBookSearchRadioButton;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolTip UScriptureUIToolTip;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ToolStripMenuItem moreToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton minimizeToolStripButton;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label20;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// //////method for handling form drag
		/// </summary>
		protected override void WndProc(ref Message m)
		{
			// Allow the base class to handle all messages first.
			base.WndProc(ref m);
			// Look for the WM_NCHITTEST message.
			int WM_NCHITTEST = 0x84;
			if (m.Msg == WM_NCHITTEST) {
				// Treat this click as a click on the caption.
				int HTCLIENT = 1;
				int HTCAPTION = 2;
				if (m.Result.ToInt32() == HTCLIENT)
					m.Result = (IntPtr)HTCAPTION;
			}
		}
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.scriptureSelectionBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.bibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newTestamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oldTestamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.startPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.scriptureReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomVerseToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.randomVerseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.randomBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookOfProverbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookOfPsalmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quranToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.favouriteVersesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bonusInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moreToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.infoToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.minimizeToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.scriptureNameLabel = new System.Windows.Forms.Label();
			this.minDetailLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.verseToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addChapterToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyCurrentVerseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verseComboBox = new System.Windows.Forms.ComboBox();
			this.chapterComboBox = new System.Windows.Forms.ComboBox();
			this.bookComboBox = new System.Windows.Forms.ComboBox();
			this.scriptureReadingPage = new System.Windows.Forms.GroupBox();
			this.readerRichTextBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.startPgQuranBtn = new System.Windows.Forms.Button();
			this.startPgBibleBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.settingsTabControl = new System.Windows.Forms.TabControl();
			this.readingPlanTabPage = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.notesTabPage = new System.Windows.Forms.TabPage();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label8 = new System.Windows.Forms.Label();
			this.favouritesTabPage = new System.Windows.Forms.TabPage();
			this.favouritesListBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.favouritesComboBox = new System.Windows.Forms.ComboBox();
			this.removeFavourite = new System.Windows.Forms.Button();
			this.favouritesLabel = new System.Windows.Forms.Label();
			this.searchTabPage = new System.Windows.Forms.TabPage();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.QuranRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.specificBookSearchComboBox = new System.Windows.Forms.ComboBox();
			this.specificBookSearchRadioButton = new System.Windows.Forms.RadioButton();
			this.NTRadioButton = new System.Windows.Forms.RadioButton();
			this.OTRadioButton = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.previousSearchButton = new System.Windows.Forms.Button();
			this.bibleRadioButton = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.searchResultsPanel = new System.Windows.Forms.Panel();
			this.searchResultsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.newSearchButton = new System.Windows.Forms.Button();
			this.aboutUsTabPage = new System.Windows.Forms.TabPage();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.basicInfoTabPage = new System.Windows.Forms.TabPage();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.settingsTabPage = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fontSampleLabel = new System.Windows.Forms.Label();
			this.changeFontButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.launchOnstartCheckBox = new System.Windows.Forms.CheckBox();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.startPage = new System.Windows.Forms.Panel();
			this.label20 = new System.Windows.Forms.Label();
			this.UScriptureUIToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStrip1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.scriptureReadingPage.SuspendLayout();
			this.settingsTabControl.SuspendLayout();
			this.readingPlanTabPage.SuspendLayout();
			this.notesTabPage.SuspendLayout();
			this.favouritesTabPage.SuspendLayout();
			this.panel1.SuspendLayout();
			this.searchTabPage.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.searchResultsPanel.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.aboutUsTabPage.SuspendLayout();
			this.basicInfoTabPage.SuspendLayout();
			this.settingsTabPage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.startPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.scriptureSelectionBtn,
			this.randomVerseToolStripButton,
			this.searchToolStripButton,
			this.infoToolStripButton,
			this.settingsToolStripButton,
			this.minimizeToolStripButton,
			this.exitToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(207, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(348, 46);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// scriptureSelectionBtn
			// 
			this.scriptureSelectionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.scriptureSelectionBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bibleToolStripMenuItem,
			this.quranToolStripMenuItem,
			this.toolStripSeparator1,
			this.startPageToolStripMenuItem});
			this.scriptureSelectionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scriptureSelectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("scriptureSelectionBtn.Image")));
			this.scriptureSelectionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.scriptureSelectionBtn.Name = "scriptureSelectionBtn";
			this.scriptureSelectionBtn.Size = new System.Drawing.Size(62, 43);
			this.scriptureSelectionBtn.Text = "&Go To";
			// 
			// bibleToolStripMenuItem
			// 
			this.bibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newTestamentToolStripMenuItem,
			this.oldTestamentToolStripMenuItem});
			this.bibleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bibleToolStripMenuItem.Image")));
			this.bibleToolStripMenuItem.Name = "bibleToolStripMenuItem";
			this.bibleToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
			this.bibleToolStripMenuItem.Text = "&Bible";
			this.bibleToolStripMenuItem.Click += new System.EventHandler(this.BibleToolStripMenuItemClick);
			// 
			// newTestamentToolStripMenuItem
			// 
			this.newTestamentToolStripMenuItem.Name = "newTestamentToolStripMenuItem";
			this.newTestamentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
			this.newTestamentToolStripMenuItem.Text = "New Testament";
			this.newTestamentToolStripMenuItem.Click += new System.EventHandler(this.NewTestamentToolStripMenuItemClick);
			// 
			// oldTestamentToolStripMenuItem
			// 
			this.oldTestamentToolStripMenuItem.Name = "oldTestamentToolStripMenuItem";
			this.oldTestamentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
			this.oldTestamentToolStripMenuItem.Text = "Old Testament";
			this.oldTestamentToolStripMenuItem.Click += new System.EventHandler(this.OldTestamentToolStripMenuItemClick);
			// 
			// quranToolStripMenuItem
			// 
			this.quranToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quranToolStripMenuItem.Image")));
			this.quranToolStripMenuItem.Name = "quranToolStripMenuItem";
			this.quranToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
			this.quranToolStripMenuItem.Text = "&Quran";
			this.quranToolStripMenuItem.Click += new System.EventHandler(this.QuranToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
			// 
			// startPageToolStripMenuItem
			// 
			this.startPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.startPageToolStripMenuItem1,
			this.scriptureReadingToolStripMenuItem,
			this.optionsToolStripMenuItem});
			this.startPageToolStripMenuItem.Name = "startPageToolStripMenuItem";
			this.startPageToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
			this.startPageToolStripMenuItem.Text = "&Page";
			// 
			// startPageToolStripMenuItem1
			// 
			this.startPageToolStripMenuItem1.Name = "startPageToolStripMenuItem1";
			this.startPageToolStripMenuItem1.Size = new System.Drawing.Size(200, 26);
			this.startPageToolStripMenuItem1.Text = "&Start page";
			this.startPageToolStripMenuItem1.Click += new System.EventHandler(this.StartPageToolStripMenuItem1Click);
			// 
			// scriptureReadingToolStripMenuItem
			// 
			this.scriptureReadingToolStripMenuItem.Name = "scriptureReadingToolStripMenuItem";
			this.scriptureReadingToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.scriptureReadingToolStripMenuItem.Text = "Scripture &reading";
			this.scriptureReadingToolStripMenuItem.Click += new System.EventHandler(this.ScriptureReadingToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.optionsToolStripMenuItem.Text = "&Tools";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);
			// 
			// randomVerseToolStripButton
			// 
			this.randomVerseToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.randomVerseToolStripMenuItem,
			this.favouriteVersesToolStripMenuItem,
			this.bonusInfoToolStripMenuItem,
			this.readingPlanToolStripMenuItem,
			this.notesToolStripMenuItem,
			this.moreToolsToolStripMenuItem});
			this.randomVerseToolStripButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomVerseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("randomVerseToolStripButton.Image")));
			this.randomVerseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.randomVerseToolStripButton.Name = "randomVerseToolStripButton";
			this.randomVerseToolStripButton.Size = new System.Drawing.Size(89, 43);
			this.randomVerseToolStripButton.Text = "&Tools";
			// 
			// randomVerseToolStripMenuItem
			// 
			this.randomVerseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bibleToolStripMenuItem1,
			this.quranToolStripMenuItem1});
			this.randomVerseToolStripMenuItem.Name = "randomVerseToolStripMenuItem";
			this.randomVerseToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.randomVerseToolStripMenuItem.Text = "Random Verse";
			// 
			// bibleToolStripMenuItem1
			// 
			this.bibleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.randomBookToolStripMenuItem,
			this.bookOfProverbsToolStripMenuItem,
			this.bookOfPsalmsToolStripMenuItem});
			this.bibleToolStripMenuItem1.Name = "bibleToolStripMenuItem1";
			this.bibleToolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
			this.bibleToolStripMenuItem1.Text = "Bible";
			// 
			// randomBookToolStripMenuItem
			// 
			this.randomBookToolStripMenuItem.Name = "randomBookToolStripMenuItem";
			this.randomBookToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.randomBookToolStripMenuItem.Text = "Random book";
			this.randomBookToolStripMenuItem.Click += new System.EventHandler(this.RandomBookToolStripMenuItemClick);
			// 
			// bookOfProverbsToolStripMenuItem
			// 
			this.bookOfProverbsToolStripMenuItem.Name = "bookOfProverbsToolStripMenuItem";
			this.bookOfProverbsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.bookOfProverbsToolStripMenuItem.Text = "Book of Proverbs";
			this.bookOfProverbsToolStripMenuItem.Click += new System.EventHandler(this.BookOfProverbsToolStripMenuItemClick);
			// 
			// bookOfPsalmsToolStripMenuItem
			// 
			this.bookOfPsalmsToolStripMenuItem.Name = "bookOfPsalmsToolStripMenuItem";
			this.bookOfPsalmsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.bookOfPsalmsToolStripMenuItem.Text = "Book of Psalms";
			this.bookOfPsalmsToolStripMenuItem.Click += new System.EventHandler(this.BookOfPsalmsToolStripMenuItemClick);
			// 
			// quranToolStripMenuItem1
			// 
			this.quranToolStripMenuItem1.Name = "quranToolStripMenuItem1";
			this.quranToolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
			this.quranToolStripMenuItem1.Text = "Quran";
			this.quranToolStripMenuItem1.Click += new System.EventHandler(this.QuranToolStripMenuItem1Click);
			// 
			// favouriteVersesToolStripMenuItem
			// 
			this.favouriteVersesToolStripMenuItem.Name = "favouriteVersesToolStripMenuItem";
			this.favouriteVersesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.favouriteVersesToolStripMenuItem.Text = "Favourites";
			this.favouriteVersesToolStripMenuItem.Click += new System.EventHandler(this.FavouritesToolStripMenuItemClick);
			// 
			// bonusInfoToolStripMenuItem
			// 
			this.bonusInfoToolStripMenuItem.Name = "bonusInfoToolStripMenuItem";
			this.bonusInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.bonusInfoToolStripMenuItem.Text = "Basic Info";
			this.bonusInfoToolStripMenuItem.Click += new System.EventHandler(this.BasicInfoToolStripMenuItemClick);
			// 
			// readingPlanToolStripMenuItem
			// 
			this.readingPlanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.readingPlanToolStripMenuItem.Name = "readingPlanToolStripMenuItem";
			this.readingPlanToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.readingPlanToolStripMenuItem.Text = "Reading Plan";
			this.readingPlanToolStripMenuItem.Click += new System.EventHandler(this.ReadingPlanToolStripMenuItemClick);
			// 
			// notesToolStripMenuItem
			// 
			this.notesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
			this.notesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.notesToolStripMenuItem.Text = "Notes";
			this.notesToolStripMenuItem.Click += new System.EventHandler(this.NotesToolStripMenuItemClick);
			// 
			// moreToolsToolStripMenuItem
			// 
			this.moreToolsToolStripMenuItem.Name = "moreToolsToolStripMenuItem";
			this.moreToolsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
			this.moreToolsToolStripMenuItem.Text = "&More..";
			this.moreToolsToolStripMenuItem.Click += new System.EventHandler(this.MoreToolsToolStripMenuItemClick);
			// 
			// searchToolStripButton
			// 
			this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.searchToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
			this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.searchToolStripButton.Name = "searchToolStripButton";
			this.searchToolStripButton.Size = new System.Drawing.Size(36, 43);
			this.searchToolStripButton.Text = "Search";
			this.searchToolStripButton.ToolTipText = "Search the scriptures";
			this.searchToolStripButton.Click += new System.EventHandler(this.SearchToolStripButtonClick);
			// 
			// infoToolStripButton
			// 
			this.infoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.infoToolStripButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.infoToolStripButton.ForeColor = System.Drawing.Color.Khaki;
			this.infoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripButton.Image")));
			this.infoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.infoToolStripButton.Name = "infoToolStripButton";
			this.infoToolStripButton.Size = new System.Drawing.Size(45, 43);
			this.infoToolStripButton.Text = "s";
			this.infoToolStripButton.ToolTipText = "About Blended Reference Scriptures";
			this.infoToolStripButton.Click += new System.EventHandler(this.InfoToolStripButtonClick);
			// 
			// settingsToolStripButton
			// 
			this.settingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.settingsToolStripButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.settingsToolStripButton.ForeColor = System.Drawing.Color.Khaki;
			this.settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripButton.Image")));
			this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.settingsToolStripButton.Name = "settingsToolStripButton";
			this.settingsToolStripButton.Size = new System.Drawing.Size(45, 43);
			this.settingsToolStripButton.Text = "@";
			this.settingsToolStripButton.ToolTipText = "Settings";
			this.settingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButtonClick);
			// 
			// minimizeToolStripButton
			// 
			this.minimizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.minimizeToolStripButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeToolStripButton.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.minimizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToolStripButton.Image")));
			this.minimizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.minimizeToolStripButton.Name = "minimizeToolStripButton";
			this.minimizeToolStripButton.Size = new System.Drawing.Size(32, 43);
			this.minimizeToolStripButton.Text = "-";
			this.minimizeToolStripButton.ToolTipText = "Minimize window";
			this.minimizeToolStripButton.Click += new System.EventHandler(this.MinimizeToolStripButtonClick);
			// 
			// exitToolStripButton
			// 
			this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.exitToolStripButton.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitToolStripButton.ForeColor = System.Drawing.Color.Red;
			this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
			this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exitToolStripButton.Name = "exitToolStripButton";
			this.exitToolStripButton.Size = new System.Drawing.Size(36, 43);
			this.exitToolStripButton.Text = "x";
			this.exitToolStripButton.ToolTipText = "Exit program";
			this.exitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButtonClick);
			// 
			// scriptureNameLabel
			// 
			this.scriptureNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.scriptureNameLabel.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scriptureNameLabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
			this.scriptureNameLabel.Location = new System.Drawing.Point(56, 24);
			this.scriptureNameLabel.Name = "scriptureNameLabel";
			this.scriptureNameLabel.Size = new System.Drawing.Size(148, 39);
			this.scriptureNameLabel.TabIndex = 8;
			this.scriptureNameLabel.Text = "Scriptures";
			this.scriptureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// minDetailLabel
			// 
			this.minDetailLabel.BackColor = System.Drawing.Color.Transparent;
			this.minDetailLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minDetailLabel.ForeColor = System.Drawing.Color.Azure;
			this.minDetailLabel.Location = new System.Drawing.Point(21, 575);
			this.minDetailLabel.Name = "minDetailLabel";
			this.minDetailLabel.Size = new System.Drawing.Size(542, 58);
			this.minDetailLabel.TabIndex = 9;
			this.minDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.toolStrip2);
			this.flowLayoutPanel1.Controls.Add(this.verseComboBox);
			this.flowLayoutPanel1.Controls.Add(this.chapterComboBox);
			this.flowLayoutPanel1.Controls.Add(this.bookComboBox);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 29);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripDropDownButton1});
			this.toolStrip2.Location = new System.Drawing.Point(445, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(16, 25);
			this.toolStrip2.TabIndex = 7;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.verseToFavouritesToolStripMenuItem,
			this.addChapterToFavouritesToolStripMenuItem,
			this.copyCurrentVerseToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// verseToFavouritesToolStripMenuItem
			// 
			this.verseToFavouritesToolStripMenuItem.Name = "verseToFavouritesToolStripMenuItem";
			this.verseToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.verseToFavouritesToolStripMenuItem.Text = "Add Verse to Favourites";
			this.verseToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.VerseToFavouritesToolStripMenuItemClick);
			// 
			// addChapterToFavouritesToolStripMenuItem
			// 
			this.addChapterToFavouritesToolStripMenuItem.Name = "addChapterToFavouritesToolStripMenuItem";
			this.addChapterToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.addChapterToFavouritesToolStripMenuItem.Text = "Add Chapter to Favourites";
			this.addChapterToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.AddChapterToFavouritesToolStripMenuItemClick);
			// 
			// copyCurrentVerseToolStripMenuItem
			// 
			this.copyCurrentVerseToolStripMenuItem.Name = "copyCurrentVerseToolStripMenuItem";
			this.copyCurrentVerseToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.copyCurrentVerseToolStripMenuItem.Text = "&Copy current verse";
			this.copyCurrentVerseToolStripMenuItem.Click += new System.EventHandler(this.CopyCurrentVerseToolStripMenuItemClick);
			// 
			// verseComboBox
			// 
			this.verseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.verseComboBox.FormattingEnabled = true;
			this.verseComboBox.Location = new System.Drawing.Point(321, 3);
			this.verseComboBox.Name = "verseComboBox";
			this.verseComboBox.Size = new System.Drawing.Size(121, 24);
			this.verseComboBox.TabIndex = 4;
			this.verseComboBox.SelectionChangeCommitted += new System.EventHandler(this.VerseComboBoxSelectionChangeCommitted);
			// 
			// chapterComboBox
			// 
			this.chapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.chapterComboBox.FormattingEnabled = true;
			this.chapterComboBox.Location = new System.Drawing.Point(194, 3);
			this.chapterComboBox.Name = "chapterComboBox";
			this.chapterComboBox.Size = new System.Drawing.Size(121, 24);
			this.chapterComboBox.TabIndex = 5;
			this.chapterComboBox.SelectedIndexChanged += new System.EventHandler(this.ChapterComboBoxSelectedIndexChanged);
			// 
			// bookComboBox
			// 
			this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bookComboBox.FormattingEnabled = true;
			this.bookComboBox.Location = new System.Drawing.Point(67, 3);
			this.bookComboBox.Name = "bookComboBox";
			this.bookComboBox.Size = new System.Drawing.Size(121, 24);
			this.bookComboBox.TabIndex = 6;
			this.bookComboBox.SelectedIndexChanged += new System.EventHandler(this.BookComboBoxSelectedIndexChanged);
			// 
			// scriptureReadingPage
			// 
			this.scriptureReadingPage.BackColor = System.Drawing.Color.Transparent;
			this.scriptureReadingPage.Controls.Add(this.readerRichTextBox);
			this.scriptureReadingPage.Controls.Add(this.flowLayoutPanel1);
			this.scriptureReadingPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scriptureReadingPage.Location = new System.Drawing.Point(68, 87);
			this.scriptureReadingPage.Name = "scriptureReadingPage";
			this.scriptureReadingPage.Size = new System.Drawing.Size(467, 476);
			this.scriptureReadingPage.TabIndex = 10;
			this.scriptureReadingPage.TabStop = false;
			this.scriptureReadingPage.Visible = false;
			// 
			// readerRichTextBox
			// 
			this.readerRichTextBox.BackColor = System.Drawing.Color.Beige;
			this.readerRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.readerRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.readerRichTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.readerRichTextBox.Location = new System.Drawing.Point(3, 45);
			this.readerRichTextBox.Name = "readerRichTextBox";
			this.readerRichTextBox.ReadOnly = true;
			this.readerRichTextBox.Size = new System.Drawing.Size(461, 428);
			this.readerRichTextBox.TabIndex = 8;
			this.readerRichTextBox.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(227, 289);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 44);
			this.label3.TabIndex = 4;
			this.label3.Text = "Z";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(227, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 41);
			this.label2.TabIndex = 3;
			this.label2.Text = "V";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// startPgQuranBtn
			// 
			this.startPgQuranBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.startPgQuranBtn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
			this.startPgQuranBtn.FlatAppearance.BorderSize = 3;
			this.startPgQuranBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
			this.startPgQuranBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.startPgQuranBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startPgQuranBtn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startPgQuranBtn.ForeColor = System.Drawing.Color.Black;
			this.startPgQuranBtn.Location = new System.Drawing.Point(305, 289);
			this.startPgQuranBtn.Name = "startPgQuranBtn";
			this.startPgQuranBtn.Size = new System.Drawing.Size(110, 44);
			this.startPgQuranBtn.TabIndex = 2;
			this.startPgQuranBtn.Text = "Quran";
			this.startPgQuranBtn.UseVisualStyleBackColor = false;
			this.startPgQuranBtn.Click += new System.EventHandler(this.StartPgQuranBtnClick);
			// 
			// startPgBibleBtn
			// 
			this.startPgBibleBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.startPgBibleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
			this.startPgBibleBtn.FlatAppearance.BorderSize = 3;
			this.startPgBibleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
			this.startPgBibleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.startPgBibleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startPgBibleBtn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startPgBibleBtn.ForeColor = System.Drawing.Color.Black;
			this.startPgBibleBtn.Location = new System.Drawing.Point(305, 182);
			this.startPgBibleBtn.Name = "startPgBibleBtn";
			this.startPgBibleBtn.Size = new System.Drawing.Size(110, 41);
			this.startPgBibleBtn.TabIndex = 1;
			this.startPgBibleBtn.Text = "Bible";
			this.startPgBibleBtn.UseVisualStyleBackColor = false;
			this.startPgBibleBtn.Click += new System.EventHandler(this.StartPgBibleBtnClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
			this.label1.Location = new System.Drawing.Point(45, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 380);
			this.label1.TabIndex = 0;
			this.label1.Text = "This min Holy Scripture\'s program contains :\r\n\r\nThe Holy Bible\r\n\r\n&&\r\n\r\nThe Holy " +
	"Quran\r\n\r\nfor self study, referencing, research ...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// settingsTabControl
			// 
			this.settingsTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.settingsTabControl.Controls.Add(this.readingPlanTabPage);
			this.settingsTabControl.Controls.Add(this.notesTabPage);
			this.settingsTabControl.Controls.Add(this.favouritesTabPage);
			this.settingsTabControl.Controls.Add(this.searchTabPage);
			this.settingsTabControl.Controls.Add(this.aboutUsTabPage);
			this.settingsTabControl.Controls.Add(this.basicInfoTabPage);
			this.settingsTabControl.Controls.Add(this.settingsTabPage);
			this.settingsTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingsTabControl.Location = new System.Drawing.Point(68, 87);
			this.settingsTabControl.Name = "settingsTabControl";
			this.settingsTabControl.SelectedIndex = 0;
			this.settingsTabControl.Size = new System.Drawing.Size(467, 476);
			this.settingsTabControl.TabIndex = 0;
			this.settingsTabControl.Visible = false;
			// 
			// readingPlanTabPage
			// 
			this.readingPlanTabPage.Controls.Add(this.label15);
			this.readingPlanTabPage.Controls.Add(this.label13);
			this.readingPlanTabPage.Controls.Add(this.linkLabel1);
			this.readingPlanTabPage.Controls.Add(this.label7);
			this.readingPlanTabPage.Location = new System.Drawing.Point(4, 29);
			this.readingPlanTabPage.Name = "readingPlanTabPage";
			this.readingPlanTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.readingPlanTabPage.Size = new System.Drawing.Size(459, 443);
			this.readingPlanTabPage.TabIndex = 0;
			this.readingPlanTabPage.Text = "Reading plan";
			this.readingPlanTabPage.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Gainsboro;
			this.label15.Location = new System.Drawing.Point(66, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(312, 36);
			this.label15.TabIndex = 3;
			this.label15.Text = "Scripture reading plan!";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Wingdings", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label13.Location = new System.Drawing.Point(66, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(312, 118);
			this.label13.TabIndex = 2;
			this.label13.Text = "&&";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(7, 22);
			this.linkLabel1.Location = new System.Drawing.Point(66, 260);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(295, 23);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Email: hobbybwanali@gmail.com";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.UseCompatibleTextRendering = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label7.Location = new System.Drawing.Point(3, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(453, 437);
			this.label7.TabIndex = 0;
			this.label7.Text = "Sorry, this Feature is not available in this version of the program, contact us t" +
	"o  check the progress. Thanks";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// notesTabPage
			// 
			this.notesTabPage.Controls.Add(this.label16);
			this.notesTabPage.Controls.Add(this.label14);
			this.notesTabPage.Controls.Add(this.linkLabel2);
			this.notesTabPage.Controls.Add(this.label8);
			this.notesTabPage.Location = new System.Drawing.Point(4, 29);
			this.notesTabPage.Name = "notesTabPage";
			this.notesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.notesTabPage.Size = new System.Drawing.Size(459, 443);
			this.notesTabPage.TabIndex = 1;
			this.notesTabPage.Text = "Notes";
			this.notesTabPage.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Gainsboro;
			this.label16.Location = new System.Drawing.Point(66, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(312, 36);
			this.label16.TabIndex = 4;
			this.label16.Text = "Scripture reading Notes!";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Wingdings", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label14.Location = new System.Drawing.Point(66, 76);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(312, 118);
			this.label14.TabIndex = 3;
			this.label14.Text = "&&";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel2
			// 
			this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(7, 22);
			this.linkLabel2.Location = new System.Drawing.Point(66, 260);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(295, 23);
			this.linkLabel2.TabIndex = 2;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Email: hobbybwanali@gmail.com";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel2.UseCompatibleTextRendering = true;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label8.Location = new System.Drawing.Point(3, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(453, 437);
			this.label8.TabIndex = 0;
			this.label8.Text = "Sorry, this Feature is not available in this version of the program, contact us t" +
	"o  check the progress. Thanks";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// favouritesTabPage
			// 
			this.favouritesTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.favouritesTabPage.Controls.Add(this.favouritesListBox);
			this.favouritesTabPage.Controls.Add(this.panel1);
			this.favouritesTabPage.Controls.Add(this.favouritesLabel);
			this.favouritesTabPage.Location = new System.Drawing.Point(4, 29);
			this.favouritesTabPage.Name = "favouritesTabPage";
			this.favouritesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.favouritesTabPage.Size = new System.Drawing.Size(459, 443);
			this.favouritesTabPage.TabIndex = 2;
			this.favouritesTabPage.Text = "Favourite";
			// 
			// favouritesListBox
			// 
			this.favouritesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.favouritesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.favouritesListBox.FormattingEnabled = true;
			this.favouritesListBox.HorizontalScrollbar = true;
			this.favouritesListBox.ItemHeight = 17;
			this.favouritesListBox.Location = new System.Drawing.Point(3, 40);
			this.favouritesListBox.Name = "favouritesListBox";
			this.favouritesListBox.Size = new System.Drawing.Size(453, 355);
			this.favouritesListBox.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.favouritesComboBox);
			this.panel1.Controls.Add(this.removeFavourite);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 395);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(453, 45);
			this.panel1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DimGray;
			this.label6.Location = new System.Drawing.Point(3, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 25);
			this.label6.TabIndex = 4;
			this.label6.Text = "show:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// favouritesComboBox
			// 
			this.favouritesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.favouritesComboBox.FormattingEnabled = true;
			this.favouritesComboBox.Location = new System.Drawing.Point(109, 10);
			this.favouritesComboBox.Name = "favouritesComboBox";
			this.favouritesComboBox.Size = new System.Drawing.Size(178, 25);
			this.favouritesComboBox.TabIndex = 3;
			this.favouritesComboBox.SelectedIndexChanged += new System.EventHandler(this.FavouritesComboBoxSelectedIndexChanged);
			// 
			// removeFavourite
			// 
			this.removeFavourite.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.removeFavourite.ForeColor = System.Drawing.Color.Red;
			this.removeFavourite.Location = new System.Drawing.Point(406, 6);
			this.removeFavourite.Name = "removeFavourite";
			this.removeFavourite.Size = new System.Drawing.Size(32, 32);
			this.removeFavourite.TabIndex = 2;
			this.removeFavourite.Text = "r";
			this.UScriptureUIToolTip.SetToolTip(this.removeFavourite, "Delete selected item");
			this.removeFavourite.UseVisualStyleBackColor = true;
			this.removeFavourite.Click += new System.EventHandler(this.RemoveFavouriteClick);
			// 
			// favouritesLabel
			// 
			this.favouritesLabel.BackColor = System.Drawing.SystemColors.Control;
			this.favouritesLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.favouritesLabel.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.favouritesLabel.ForeColor = System.Drawing.Color.DarkCyan;
			this.favouritesLabel.Location = new System.Drawing.Point(3, 3);
			this.favouritesLabel.Name = "favouritesLabel";
			this.favouritesLabel.Size = new System.Drawing.Size(453, 37);
			this.favouritesLabel.TabIndex = 1;
			this.favouritesLabel.Text = "Favourites";
			this.favouritesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// searchTabPage
			// 
			this.searchTabPage.BackColor = System.Drawing.Color.Gainsboro;
			this.searchTabPage.Controls.Add(this.searchResultsPanel);
			this.searchTabPage.Controls.Add(this.searchPanel);
			this.searchTabPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchTabPage.Location = new System.Drawing.Point(4, 29);
			this.searchTabPage.Name = "searchTabPage";
			this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.searchTabPage.Size = new System.Drawing.Size(459, 443);
			this.searchTabPage.TabIndex = 3;
			this.searchTabPage.Text = "Search";
			// 
			// searchPanel
			// 
			this.searchPanel.BackColor = System.Drawing.SystemColors.Control;
			this.searchPanel.Controls.Add(this.QuranRadioButton);
			this.searchPanel.Controls.Add(this.groupBox3);
			this.searchPanel.Controls.Add(this.label5);
			this.searchPanel.Controls.Add(this.flowLayoutPanel2);
			this.searchPanel.Controls.Add(this.bibleRadioButton);
			this.searchPanel.Controls.Add(this.label4);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchPanel.Location = new System.Drawing.Point(3, 3);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(453, 437);
			this.searchPanel.TabIndex = 2;
			// 
			// QuranRadioButton
			// 
			this.QuranRadioButton.Location = new System.Drawing.Point(41, 329);
			this.QuranRadioButton.Name = "QuranRadioButton";
			this.QuranRadioButton.Size = new System.Drawing.Size(104, 24);
			this.QuranRadioButton.TabIndex = 4;
			this.QuranRadioButton.Text = "Quran";
			this.QuranRadioButton.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.specificBookSearchComboBox);
			this.groupBox3.Controls.Add(this.specificBookSearchRadioButton);
			this.groupBox3.Controls.Add(this.NTRadioButton);
			this.groupBox3.Controls.Add(this.OTRadioButton);
			this.groupBox3.Location = new System.Drawing.Point(63, 141);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(356, 170);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "...";
			// 
			// specificBookSearchComboBox
			// 
			this.specificBookSearchComboBox.BackColor = System.Drawing.Color.Gainsboro;
			this.specificBookSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.specificBookSearchComboBox.ForeColor = System.Drawing.Color.DimGray;
			this.specificBookSearchComboBox.FormattingEnabled = true;
			this.specificBookSearchComboBox.IntegralHeight = false;
			this.specificBookSearchComboBox.Location = new System.Drawing.Point(112, 87);
			this.specificBookSearchComboBox.MaxDropDownItems = 15;
			this.specificBookSearchComboBox.Name = "specificBookSearchComboBox";
			this.specificBookSearchComboBox.Size = new System.Drawing.Size(233, 28);
			this.specificBookSearchComboBox.TabIndex = 4;
			// 
			// specificBookSearchRadioButton
			// 
			this.specificBookSearchRadioButton.Location = new System.Drawing.Point(3, 87);
			this.specificBookSearchRadioButton.Name = "specificBookSearchRadioButton";
			this.specificBookSearchRadioButton.Size = new System.Drawing.Size(79, 24);
			this.specificBookSearchRadioButton.TabIndex = 3;
			this.specificBookSearchRadioButton.Text = "From:";
			this.specificBookSearchRadioButton.UseVisualStyleBackColor = true;
			this.specificBookSearchRadioButton.CheckedChanged += new System.EventHandler(this.SpecificBookSearchRadioButtonCheckedChanged);
			// 
			// NTRadioButton
			// 
			this.NTRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.NTRadioButton.Location = new System.Drawing.Point(3, 47);
			this.NTRadioButton.Name = "NTRadioButton";
			this.NTRadioButton.Size = new System.Drawing.Size(350, 24);
			this.NTRadioButton.TabIndex = 1;
			this.NTRadioButton.Text = "New Testament";
			this.NTRadioButton.UseVisualStyleBackColor = true;
			// 
			// OTRadioButton
			// 
			this.OTRadioButton.Checked = true;
			this.OTRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.OTRadioButton.Location = new System.Drawing.Point(3, 23);
			this.OTRadioButton.Name = "OTRadioButton";
			this.OTRadioButton.Size = new System.Drawing.Size(350, 24);
			this.OTRadioButton.TabIndex = 0;
			this.OTRadioButton.TabStop = true;
			this.OTRadioButton.Text = "Old Testament";
			this.OTRadioButton.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new System.Drawing.Point(0, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(453, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Search from: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.flowLayoutPanel2.Controls.Add(this.searchButton);
			this.flowLayoutPanel2.Controls.Add(this.searchTextBox);
			this.flowLayoutPanel2.Controls.Add(this.previousSearchButton);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.ForeColor = System.Drawing.Color.DarkCyan;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 40);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.flowLayoutPanel2.Size = new System.Drawing.Size(453, 34);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Location = new System.Drawing.Point(3, 3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 28);
			this.searchButton.TabIndex = 0;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.searchTextBox.Location = new System.Drawing.Point(84, 3);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(305, 27);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBoxKeyPress);
			// 
			// previousSearchButton
			// 
			this.previousSearchButton.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.previousSearchButton.Location = new System.Drawing.Point(395, 3);
			this.previousSearchButton.Name = "previousSearchButton";
			this.previousSearchButton.Size = new System.Drawing.Size(52, 28);
			this.previousSearchButton.TabIndex = 2;
			this.previousSearchButton.Text = "O";
			this.previousSearchButton.UseVisualStyleBackColor = true;
			this.previousSearchButton.Click += new System.EventHandler(this.PreviousSearchButtonClick);
			// 
			// bibleRadioButton
			// 
			this.bibleRadioButton.Checked = true;
			this.bibleRadioButton.Location = new System.Drawing.Point(41, 111);
			this.bibleRadioButton.Name = "bibleRadioButton";
			this.bibleRadioButton.Size = new System.Drawing.Size(104, 24);
			this.bibleRadioButton.TabIndex = 3;
			this.bibleRadioButton.TabStop = true;
			this.bibleRadioButton.Text = "Bible";
			this.bibleRadioButton.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkCyan;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(453, 40);
			this.label4.TabIndex = 0;
			this.label4.Text = "Search the Scriptures";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// searchResultsPanel
			// 
			this.searchResultsPanel.Controls.Add(this.searchResultsRichTextBox);
			this.searchResultsPanel.Controls.Add(this.flowLayoutPanel3);
			this.searchResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchResultsPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchResultsPanel.Location = new System.Drawing.Point(3, 3);
			this.searchResultsPanel.Name = "searchResultsPanel";
			this.searchResultsPanel.Size = new System.Drawing.Size(453, 437);
			this.searchResultsPanel.TabIndex = 6;
			this.searchResultsPanel.Visible = false;
			// 
			// searchResultsRichTextBox
			// 
			this.searchResultsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchResultsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchResultsRichTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchResultsRichTextBox.Location = new System.Drawing.Point(0, 34);
			this.searchResultsRichTextBox.Name = "searchResultsRichTextBox";
			this.searchResultsRichTextBox.Size = new System.Drawing.Size(453, 403);
			this.searchResultsRichTextBox.TabIndex = 1;
			this.searchResultsRichTextBox.Text = "No previous search results found, type a word in the searchbar........";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
			this.flowLayoutPanel3.Controls.Add(this.newSearchButton);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.ForeColor = System.Drawing.Color.DarkCyan;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel3.Size = new System.Drawing.Size(453, 34);
			this.flowLayoutPanel3.TabIndex = 0;
			// 
			// newSearchButton
			// 
			this.newSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newSearchButton.Location = new System.Drawing.Point(356, 3);
			this.newSearchButton.Name = "newSearchButton";
			this.newSearchButton.Size = new System.Drawing.Size(94, 28);
			this.newSearchButton.TabIndex = 0;
			this.newSearchButton.Text = "New Search";
			this.newSearchButton.UseVisualStyleBackColor = true;
			this.newSearchButton.Click += new System.EventHandler(this.NewSearchButtonClick);
			// 
			// aboutUsTabPage
			// 
			this.aboutUsTabPage.Controls.Add(this.linkLabel3);
			this.aboutUsTabPage.Controls.Add(this.label19);
			this.aboutUsTabPage.Controls.Add(this.label18);
			this.aboutUsTabPage.Controls.Add(this.label17);
			this.aboutUsTabPage.Location = new System.Drawing.Point(4, 29);
			this.aboutUsTabPage.Name = "aboutUsTabPage";
			this.aboutUsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.aboutUsTabPage.Size = new System.Drawing.Size(459, 443);
			this.aboutUsTabPage.TabIndex = 4;
			this.aboutUsTabPage.Text = "About us";
			this.aboutUsTabPage.UseVisualStyleBackColor = true;
			// 
			// linkLabel3
			// 
			this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.linkLabel3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(177, 22);
			this.linkLabel3.Location = new System.Drawing.Point(3, 288);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.linkLabel3.Size = new System.Drawing.Size(453, 142);
			this.linkLabel3.TabIndex = 3;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = resources.GetString("linkLabel3.Text");
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel3.UseCompatibleTextRendering = true;
			// 
			// label19
			// 
			this.label19.Dock = System.Windows.Forms.DockStyle.Top;
			this.label19.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Gainsboro;
			this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
			this.label19.Location = new System.Drawing.Point(3, 243);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(453, 45);
			this.label19.TabIndex = 2;
			this.label19.Text = "About the Developer";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Dock = System.Windows.Forms.DockStyle.Top;
			this.label18.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.DimGray;
			this.label18.Location = new System.Drawing.Point(3, 49);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(453, 194);
			this.label18.TabIndex = 1;
			this.label18.Text = resources.GetString("label18.Text");
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Dock = System.Windows.Forms.DockStyle.Top;
			this.label17.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
			this.label17.Location = new System.Drawing.Point(3, 3);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(453, 46);
			this.label17.TabIndex = 0;
			this.label17.Text = "About Blended Reference Scriptures";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// basicInfoTabPage
			// 
			this.basicInfoTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
			this.basicInfoTabPage.Controls.Add(this.label12);
			this.basicInfoTabPage.Controls.Add(this.label11);
			this.basicInfoTabPage.Controls.Add(this.label10);
			this.basicInfoTabPage.Controls.Add(this.label9);
			this.basicInfoTabPage.Location = new System.Drawing.Point(4, 29);
			this.basicInfoTabPage.Name = "basicInfoTabPage";
			this.basicInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.basicInfoTabPage.Size = new System.Drawing.Size(459, 443);
			this.basicInfoTabPage.TabIndex = 5;
			this.basicInfoTabPage.Text = "Basic Info";
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DimGray;
			this.label12.Location = new System.Drawing.Point(3, 281);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(453, 44);
			this.label12.TabIndex = 3;
			this.label12.Text = "English Translation of the Meanings by Mohammad Marmaduke Pickthal";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DarkCyan;
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.Location = new System.Drawing.Point(3, 214);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(453, 67);
			this.label11.TabIndex = 2;
			this.label11.Text = "THE HOLY QURAN";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DimGray;
			this.label10.Location = new System.Drawing.Point(3, 69);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(453, 145);
			this.label10.TabIndex = 1;
			this.label10.Text = resources.GetString("label10.Text");
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkCyan;
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label9.Location = new System.Drawing.Point(3, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(453, 66);
			this.label9.TabIndex = 0;
			this.label9.Text = "THE HOLY BIBLE";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// settingsTabPage
			// 
			this.settingsTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.settingsTabPage.Controls.Add(this.groupBox2);
			this.settingsTabPage.Controls.Add(this.groupBox1);
			this.settingsTabPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingsTabPage.ForeColor = System.Drawing.Color.White;
			this.settingsTabPage.Location = new System.Drawing.Point(4, 29);
			this.settingsTabPage.Name = "settingsTabPage";
			this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.settingsTabPage.Size = new System.Drawing.Size(459, 443);
			this.settingsTabPage.TabIndex = 6;
			this.settingsTabPage.Text = "Settings";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox2.Controls.Add(this.fontSampleLabel);
			this.groupBox2.Controls.Add(this.changeFontButton);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.groupBox2.Location = new System.Drawing.Point(3, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(453, 163);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "font settings..";
			// 
			// fontSampleLabel
			// 
			this.fontSampleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fontSampleLabel.Location = new System.Drawing.Point(3, 23);
			this.fontSampleLabel.Name = "fontSampleLabel";
			this.fontSampleLabel.Size = new System.Drawing.Size(447, 98);
			this.fontSampleLabel.TabIndex = 3;
			this.fontSampleLabel.Text = "font sample";
			this.fontSampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// changeFontButton
			// 
			this.changeFontButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.changeFontButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.changeFontButton.Location = new System.Drawing.Point(3, 121);
			this.changeFontButton.Name = "changeFontButton";
			this.changeFontButton.Size = new System.Drawing.Size(447, 39);
			this.changeFontButton.TabIndex = 2;
			this.changeFontButton.Text = "Change Font";
			this.changeFontButton.UseVisualStyleBackColor = false;
			this.changeFontButton.Click += new System.EventHandler(this.ChangeFontButtonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.launchOnstartCheckBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(453, 58);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// launchOnstartCheckBox
			// 
			this.launchOnstartCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.launchOnstartCheckBox.Location = new System.Drawing.Point(3, 23);
			this.launchOnstartCheckBox.Name = "launchOnstartCheckBox";
			this.launchOnstartCheckBox.Size = new System.Drawing.Size(447, 24);
			this.launchOnstartCheckBox.TabIndex = 0;
			this.launchOnstartCheckBox.Text = "Launch on startup";
			this.launchOnstartCheckBox.UseVisualStyleBackColor = true;
			this.launchOnstartCheckBox.CheckStateChanged += new System.EventHandler(this.LaunchOnstartCheckBoxCheckStateChanged);
			// 
			// startPage
			// 
			this.startPage.BackColor = System.Drawing.Color.Transparent;
			this.startPage.Controls.Add(this.label20);
			this.startPage.Controls.Add(this.label3);
			this.startPage.Controls.Add(this.label1);
			this.startPage.Controls.Add(this.startPgQuranBtn);
			this.startPage.Controls.Add(this.label2);
			this.startPage.Controls.Add(this.startPgBibleBtn);
			this.startPage.Location = new System.Drawing.Point(68, 87);
			this.startPage.Name = "startPage";
			this.startPage.Size = new System.Drawing.Size(467, 476);
			this.startPage.TabIndex = 11;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label20.Location = new System.Drawing.Point(45, 442);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(233, 23);
			this.label20.TabIndex = 6;
			this.label20.Text = "by Hobby Mwase Bwanali";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(600, 650);
			this.Controls.Add(this.settingsTabControl);
			this.Controls.Add(this.startPage);
			this.Controls.Add(this.minDetailLabel);
			this.Controls.Add(this.scriptureNameLabel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.scriptureReadingPage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Blended Reference Scriptures, min";
			this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.scriptureReadingPage.ResumeLayout(false);
			this.settingsTabControl.ResumeLayout(false);
			this.readingPlanTabPage.ResumeLayout(false);
			this.notesTabPage.ResumeLayout(false);
			this.favouritesTabPage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.searchTabPage.ResumeLayout(false);
			this.searchPanel.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.searchResultsPanel.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.aboutUsTabPage.ResumeLayout(false);
			this.basicInfoTabPage.ResumeLayout(false);
			this.settingsTabPage.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.startPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}