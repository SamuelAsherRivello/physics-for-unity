using UnityEditor;

namespace RMC.UnityGamePhysics.Shared
{

	public class ProjectUtilities
	{
		private const string MenuItemPath = "Window/RMC/Physics For Unity/";
		private const int MenuItemPriority = -1000;
		
		[MenuItem(MenuItemPath + "/Open Section_01", priority = MenuItemPriority)]
		public static void OpenFolder_Section_01()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_01/");
		}

		[MenuItem(MenuItemPath + "/Open Section_02", priority = MenuItemPriority)]
		public static void OpenFolder_Section_02()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_02/");
		}

		[MenuItem(MenuItemPath + "/Open Section_03", priority = MenuItemPriority)]
		public static void OpenFolder_Section_03()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_03/");
		}

		[MenuItem(MenuItemPath + "/Open Section_04", priority = MenuItemPriority)]
		public static void OpenFolder_Section_04()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_04/");
		}

		[MenuItem(MenuItemPath + "/Open Section_05", priority = MenuItemPriority)]
		public static void OpenFolder_Section_05()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_05/");
		}

		[MenuItem(MenuItemPath + "/Open Section_06", priority = MenuItemPriority)]
		public static void OpenFolder_Section_06()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_06/");
		}

		[MenuItem(MenuItemPath + "/Open Section_07", priority = MenuItemPriority)]
		public static void OpenFolder_Section_07()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_07/");
		}

		private static void CloseAllAndOpenOne(string path)
		{
			FolderUtilities.CloseAllAndOpenOne(path);
		}

		//[MenuItem(MenuItemPath + "/Reimport All Scripts")]
		public static void ForceRebuild()
		{
			string[] rebuildSymbols = { "RebuildToggle1", "RebuildToggle2" };
			string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(
				EditorUserBuildSettings.selectedBuildTargetGroup);
			var definesStringTemp = definesString;
			if (definesStringTemp.Contains(rebuildSymbols[0]))
			{
				definesStringTemp = definesStringTemp.Replace(rebuildSymbols[0], rebuildSymbols[1]);
			}
			else if (definesStringTemp.Contains(rebuildSymbols[1]))
			{
				definesStringTemp = definesStringTemp.Replace(rebuildSymbols[1], rebuildSymbols[0]);
			}
			else
			{
				definesStringTemp += ";" + rebuildSymbols[0];
			}
			PlayerSettings.SetScriptingDefineSymbolsForGroup(
				EditorUserBuildSettings.selectedBuildTargetGroup,
				definesStringTemp);
			PlayerSettings.SetScriptingDefineSymbolsForGroup(
				EditorUserBuildSettings.selectedBuildTargetGroup,
				definesString);
		}
	}
}