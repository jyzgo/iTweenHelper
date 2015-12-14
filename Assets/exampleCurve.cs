using UnityEngine;
using System.Collections;

public class exampleCurve : MonoBehaviour {

	// Use this for initialization
	void Start () {
		curEvent = GetComponent<iTweenEvent>();
	}
	iTweenEvent curEvent;

	public Vector3 TargetPos;

	void OnGUI()
	{
		if(GUILayout.Button("Play"))
		{
			curEvent.Play();
		}
	}

}
