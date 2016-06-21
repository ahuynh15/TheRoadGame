using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (this);
	}
}
