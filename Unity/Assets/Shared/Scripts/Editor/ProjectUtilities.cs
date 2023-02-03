using UnityEditor;

namespace RMC.UnityGamePhysics.Shared
{
	public class ProjectUtilities
	{
		[MenuItem("Window/Physics For Unity/Open Section_01")]
		public static void OpenFolder_Section_01()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_01/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_02")]
		public static void OpenFolder_Section_02()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_02/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_03")]
		public static void OpenFolder_Section_03()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_03/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_04")]
		public static void OpenFolder_Section_04()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_04/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_05")]
		public static void OpenFolder_Section_05()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_05/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_06")]
		public static void OpenFolder_Section_06()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_06/");
		}

		[MenuItem("Window/Physics For Unity/Open Section_07")]
		public static void OpenFolder_Section_07()
		{
			CloseAllAndOpenOne("Assets/Sections/Section_07/");
		}

		private static void CloseAllAndOpenOne(string path)
		{
			FolderUtilities.CloseAllAndOpenOne(path);
		}

		//[MenuItem("Window/Physics For Unity/Reimport All Scripts")]
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