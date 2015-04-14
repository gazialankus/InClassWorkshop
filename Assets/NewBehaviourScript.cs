using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyFunc();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MyFunc() {
		Debug.Log("myfunc was called");
	}
}
