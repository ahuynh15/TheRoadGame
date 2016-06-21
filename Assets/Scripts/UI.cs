using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (this);
	}
}
