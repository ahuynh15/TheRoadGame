using UnityEngine;
using System.Collections;

public class LoadDestroy : MonoBehaviour {

	void OnLevelWasLoaded () {
		Destroy(this);
	}
}
