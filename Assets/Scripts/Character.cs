using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Character : MonoBehaviour {
	
	public int health;
	public Slider healthBar;
	public int hunger;
	public Slider hungerBar;
	public int thirst;
	public Slider thirstBar;

	void Awake () {
		DontDestroyOnLoad (this);
	}

	void Start () {
		health = 60;
		hunger = 50;
		thirst = 40;
	}
	
	// Update is called once per frame
	void Update () {
		if (health < 0) {
			health = 0;
		}
		if (health > 100) {
			health = 100;
		}
		if (hunger < 0) {
			hunger = 0;
		}
		if (hunger > 100) {
			hunger = 100;
		}
		if (thirst < 0) {
			thirst = 0;
		}
		if (thirst > 100) {
			thirst = 100;
		}
		healthBar.value = health;
		hungerBar.value = hunger;
		thirstBar.value = thirst;
	}

	public void setHealth (int health) {
		this.health = health;
	}

	public void setThirst (int thirst) {
		this.thirst = thirst;
	}

	public void setHunger (int hunger) {
		this.hunger = hunger;
	}

	public void adjustHealth (int change) {
		this.health += change;
	}

	public void adjustHunger (int change) {
		this.hunger += change;
	}

	public void adjustThirst (int change) {
		this.thirst += change;
	}
}