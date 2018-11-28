using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	void Start()
	{
		var pathToBundle = Application.streamingAssetsPath + "/scene1";
		AssetBundle bundle = AssetBundle.LoadFromFile(pathToBundle);
		string[] scenes = bundle.GetAllScenePaths();
		string scene = Path.GetFileNameWithoutExtension(scenes[0]);
		SceneManager.LoadScene(scene);
	}
}
