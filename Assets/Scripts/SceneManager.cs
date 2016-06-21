using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public int sceneNumber;
	public string day;
	public Text dayDisplay;
	public Character father;
	public Character son;
	public GameObject FatherUI;
	public GameObject SonUI;
	public Button one;
	public Button two;

	void Awake () {
		DontDestroyOnLoad (this);
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			Application.LoadLevel("Menu");
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		sceneNumber = 1;
		day = "Day 1";
		dayDisplay.text = day;
	}

	public void nextScene () {
		sceneNumber += 1;
		if (father.health == 0 || father.hunger == 0 || father.thirst == 0 || son.health == 0 || son.hunger == 0 || son.thirst == 0) {
			Application.LoadLevel("GameOver");
			dayDisplay.transform.localPosition = new Vector3 (0,0,0);
			day = "GAME OVER";
			sceneNumber = 100;
		} else if (sceneNumber == 1) {
			Application.LoadLevel("Day1a");
			day = "Day 1";
		} else if (sceneNumber == 2) {
			Application.LoadLevel("Day1b");
			day = "Day 1";
		} else if (sceneNumber == 3) {
			Application.LoadLevel("Day2a");
			day = "Day 2";
		} else if (sceneNumber == 4) {
			Application.LoadLevel("Day2b");
			day = "Day 2";
		} else if (sceneNumber == 5) {
			Application.LoadLevel("Day3a");
			day = "Day 3";
		} else if (sceneNumber == 6) {
			Application.LoadLevel("Day3b");
			day = "Day 3";
		} else if (sceneNumber == 7) {
			Application.LoadLevel("Day4a");
			day = "Day 4";
		} else if (sceneNumber == 8) {
			Application.LoadLevel("Day4b");
			day = "Day 4";
		} else if (sceneNumber == 9) {
			Application.LoadLevel("Day5a");
			day = "Day 5";
		} else if (sceneNumber == 10) {
			Application.LoadLevel("Day5b");
			day = "Day 5";
		} else if (sceneNumber == 11) {
			Application.LoadLevel("Day6a");
			day = "Day 6";
		} else if (sceneNumber == 12) {
			Application.LoadLevel("Day6b");
			day = "Day 6";
		} else if (sceneNumber == 13) {
			Application.LoadLevel("Day7a");
			day = "Day 7";
		} else if (sceneNumber == 14) {
			Application.LoadLevel("Day7b");
			day = "Day 7";
		} else {
			Application.LoadLevel("End");
			day = "THE END";
		}
		dayDisplay.text = day;
	}
}
