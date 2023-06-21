using UnityEditor;
using System;
using System.Collections.Generic;

public class BuildScript 
{
	
	static string[] SCENES = FindEnabledEditorScenes();

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
	string[] defaultScene = { 
            "Assets/Scenes/SampleScene.unity"
            };
	    
        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk" ,
            BuildTarget.Android, BuildOptions.None);
    }

}
