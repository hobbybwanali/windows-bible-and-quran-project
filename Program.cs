/*
 * Created by SharpDevelop. Hobby Mwase
 * User: Hobby Mwase
 * Date: 7/13/2021
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;


namespace UnityScriptures
{
	public enum FavouriteType
	{
Chapter,
Verse

	}
	public enum FavouriteAction
	{
Add,
Remove}

	;
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		// GUI independent methods
		/// <summary>
		/// Adds or Removes Favourite Verses or Actions from the storage
		/// </summary>
		/// <param name="action">action to be perfomed</param>
		/// <param name="type">type of favourite e.g verse</param>
		/// <param name="text">the text to be handled</param>
		/// <returns>bool success or failed</returns>
		public static bool HandleFavourites(FavouriteAction action, FavouriteType type,ref string text)
		{
			bool handleSuccess=false;
			var favouriteStorage = Properties.UScriptureSettings.Default.lost;
			//switch the favourites storage space
			switch (type) {
				case FavouriteType.Chapter:
					favouriteStorage = Properties.UScriptureSettings.Default.FavouriteChapters;
					break;
				case FavouriteType.Verse:
					favouriteStorage = Properties.UScriptureSettings.Default.FavouriteVerses;
					break;
			}
			// switch the action to be perfomed on favourites the storage space
			switch (action) {
				case FavouriteAction.Add:
					if (!favouriteStorage.Contains(text)) {
						favouriteStorage.Add(text);
						Properties.UScriptureSettings.Default.Save();
						handleSuccess=true;
					}
					break;
				case FavouriteAction.Remove:
					try {
						favouriteStorage.Remove(text);
						handleSuccess=true;
					} catch (Exception) {}
					Properties.UScriptureSettings.Default.Save();
					break;
			}
			return handleSuccess;
		}
		
		
	}
}
