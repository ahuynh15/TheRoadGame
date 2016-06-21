using UnityEngine;
using System.Collections;

public class EscDestroy : MonoBehaviour {

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			Destroy(gameObject);
		}
	}
}
