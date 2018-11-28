using UnityEngine;

public class ScriptableRef : MonoBehaviour
{
	public TestScript Test;

	void Start () {
		Debug.Log("Test:"+Test);
		Test.MetodTest();
	}
}
