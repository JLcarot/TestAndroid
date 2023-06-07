[UnityEditor.MenuItem("CUSTOM/Test Android Build Step")]
static void androidBuild ()
{
    Debug.Log("Command line build android version\n------------------\n------------------");

    string[] scenes = GetBuildScenes();
    string path = GetBuildPathAndroid();
    if(scenes == null || scenes.Length==0 || path == null)
        return;

    Debug.Log(string.Format("Path: \"{0}\"", path));
    for(int i=0; i<scenes.Length; ++i)
    {
        Debug.Log(string.Format("Scene[{0}]: \"{1}\"", i, scenes[i]));
    }

    Debug.Log("Starting Android Build!");
    BuildPipeline.BuildPlayer(scenes, path, BuildTarget.Android, BuildOptions.None);
}