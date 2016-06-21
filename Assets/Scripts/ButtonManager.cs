using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManager : MonoBehaviour {	
	
	public SceneManager s;
	public Character father;
	public Character son;
	public Button one;
	public Button two;
	public Text textOne;
	public Text textTwo;
	public string action1;
	public string action2;
	
	void Awake () {
		DontDestroyOnLoad (this);
	}
	
	void Start () {
		s = GameObject.Find ("SceneManager").transform.GetComponent<SceneManager>();
		father = GameObject.Find ("FatherManager").transform.GetComponent<Character>();
		son = GameObject.Find ("SonManager").transform.GetComponent<Character>();
		textOne.text = "Scavenge";
		textTwo.text = "Rest";
		action1 = "Scavenge";
		action2 = "Rest";
	}

	void Update () {
		if(s.sceneNumber % 2 == 1 && s.sceneNumber != 15) {
			textOne.text = "Scavenge";
			textTwo.text = "Rest";
			action1 = "Scavenge";
			action2 = "Rest";
		} else if (s.sceneNumber == 2) {
			textOne.text = "Drink";
			textTwo.text = "Give to Son";
			action1 = "Drink";
			action2 = "Give to Son";
		} else if (s.sceneNumber == 4) {
			textOne.text = "Shoot";
			textTwo.text = "Back Down";
			action1 = "Shoot";
			action2 = "Back Down";
		} else if (s.sceneNumber == 6) {
			textOne.text = "Hide";
			textTwo.text = "Escape";
			action1 = "Hide";
			action2 = "Escape";
		} else if (s.sceneNumber == 8) {
			textOne.text = "Ignore";
			textTwo.text = "Investigate";
			action1 = "Ignore";
			action2 = "Investigate";
		} else if (s.sceneNumber == 10) {
			textOne.text = "Charity";
			textTwo.text = "Leave";
			action1 = "Charity";
			action2 = "Leave";
		} else if (s.sceneNumber == 12) {
			textOne.text = "Shoot Him";
			textTwo.text = "Let Him Go";
			action1 = "Shoot Him";
			action2 = "Let Him Go";
		} else if (s.sceneNumber == 14) {
			textOne.text = "Next";
			action1 = "Next";
			two.transform.localPosition = new Vector3 (-1000,-1000,0);
			one.transform.localPosition = new Vector3(0,100,0);
		} else if (s.sceneNumber == 100) {
			textOne.text = "Next";
			action1 = "Next";
			two.transform.localPosition = new Vector3 (-1000,-1000,0);
			one.transform.localPosition = new Vector3 (-1000,-1000,0);
		} else {
			one.transform.localPosition = new Vector3 (-1000,-1000,0);
		}
	}

	public void doAction1 () {
		if(action1.Equals("Scavenge")) {
			scavenge();
		} else if (action1.Equals("Drink")) {
			drink();
		} else if (action1.Equals("Shoot")) {
			shootBandit();
		} else if (action1.Equals("Hide")) {
			hide();
		} else if (action1.Equals("Ignore")) {
			ignore();
		} else if (action1.Equals("Charity")) {
			charity();
		} else if (action1.Equals("Shoot Him")) {
			shootBandit();
		} else {
			next();
		}
	}

	public void doAction2 () {
		if(action2.Equals("Rest")) {
			rest();
		} else if (action2.Equals("Give to Son")) {
			giveToSon();
		} else if (action2.Equals("Back Down")) {
			backDown();
		} else if (action2.Equals("Escape")) {
			escape();
		} else if (action2.Equals("Investigate")) {
			investigate();
		} else if (action2.Equals("Leave")) {
			leave();
		} else if (action2.Equals("Let Him Go")) {
			letGo();
		} else {
			next();
		}
	}
	
	//Daily Events
	public void scavenge () {
		if(s.sceneNumber == 13) {
			father.setHealth (1);
		} else {
			father.adjustHealth ((int)Random.Range (-20F, 0F));
			father.adjustHunger ((int)Random.Range (0F, 10F));
			father.adjustThirst ((int)Random.Range (0F, 10F));
			son.adjustHealth ((int)Random.Range (-15F, 0F));
			son.adjustHunger ((int)Random.Range (0F, 10F));
			son.adjustThirst ((int)Random.Range (0F, 10F));
		}
		s.nextScene ();
	}
	
	public void rest () {
		if(s.sceneNumber == 13) {
			father.setHealth (1);
		} else {
			father.adjustHealth ((int)Random.Range (5F, 10F));
			father.adjustHunger (-10);
			father.adjustThirst (-12);
			son.adjustHealth ((int)Random.Range (5F, 10F));
			son.adjustHunger (-10);
			son.adjustThirst (-12);
		}
		s.nextScene ();
	}
	
	//DAY 1 Soda
	public void drink () {
		father.adjustThirst (20);
		s.nextScene ();
	}
	
	public void giveToSon () {
		son.adjustThirst (20);
		s.nextScene ();
	}
	
	//DAY 2 Scavengers
	public void shoot () {
		son.adjustHealth (-20);
		s.nextScene ();
	}
	
	public void backDown () {
		father.setHealth (0);
		son.setHealth (0);
		s.nextScene ();
	}
	
	//DAY 3 Cannibals
	public void hide () {
		father.setHealth (0);
		son.setHealth (0);
		s.nextScene ();
	}
	
	public void escape () {
		father.adjustThirst (-15);
		son.adjustThirst (-15);
		s.nextScene ();
	}
	
	//DAY 4 Bomb Shelter
	public void ignore () {
		father.adjustHunger (-5);
		father.adjustThirst (-5);
		son.adjustHunger (-5);
		son.adjustThirst (-5);
		s.nextScene ();
	}
	
	public void investigate () {
		father.adjustHealth (10);
		father.adjustHunger (10);
		father.adjustThirst (10);
		son.adjustHealth (15);
		son.adjustHunger (15);
		son.adjustThirst (15);
		s.nextScene ();
	}
	
	//DAY 5 Old Man
	public void charity () {
		father.adjustHunger (-10);
		father.adjustThirst (-10);
		son.adjustHunger (-10);
		son.adjustThirst (-10);
		s.nextScene ();
	}
	
	public void leave () {
		//Nothing Happens
		s.nextScene ();
	}
	
	//DAY 6 Robber
	public void shootBandit() {
		father.adjustHealth (-10);
		son.adjustHealth (-10);
		s.nextScene ();
	}
	
	public void letGo () {
		father.adjustHunger (-20);
		father.adjustThirst (-20);
		son.adjustHunger (-15);
		son.adjustThirst (-15);
		s.nextScene ();
	}
	
	//DAY 7 Arrow
	public void next () {
		father.setHealth (1);
		father.setHunger (1);
		father.setThirst (1);
		s.nextScene ();
	}
}
