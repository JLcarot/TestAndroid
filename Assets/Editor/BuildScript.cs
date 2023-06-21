public class BuildScript 
{
    static void PerformBuild()
    {
        string[] defaultScene = { 
            "Assets/MyGame/Scenes/MyGame_TitleScene.unity",
            "Assets/MyGame/Scenes/MyGame_MainScene.unity",
            "Assets/MyGame/Scenes/MyGame_EpisodeScene.unity",
            };

        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk" ,
            BuildTarget.Android, BuildOptions.None);
    }

}
