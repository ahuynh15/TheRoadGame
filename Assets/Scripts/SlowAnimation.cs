using UnityEngine;
using System.Collections;

public class SlowAnimation : MonoBehaviour {

	public string animationName;
	
	void Update () {
		GetComponent<Animation>()[animationName].speed = 0.1F;
	}
}
