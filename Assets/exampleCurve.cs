using UnityEngine;
using System.Collections;

public class exampleCurve : MonoBehaviour {

	// Use this for initialization
	void Start () {
		curEvent = GetComponent<iTweenEvent>();

		//Modify path to target position,and reflect the path
		curEvent.SetTargetPos(Target.transform.localPosition,true);
	}
	iTweenEvent curEvent;

	public GameObject Target;

	void OnGUI()
	{
		if(GUILayout.Button("Play"))
		{
			curEvent.Play();
		}
	}

}
