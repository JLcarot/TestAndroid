public class BuildScript 
{

    private static string[] FindEnabledEditorScenes() {
		List<string> EditorScenes = new List<string>();
		foreach(EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
			if (!scene.enabled) continue;
			EditorScenes.Add(scene.path);
		}
		return EditorScenes.ToArray();
	}
    
    static void PerformBuild()
    {

        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk" ,
            BuildTarget.Android, BuildOptions.None);
    }

}
