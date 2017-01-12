using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public Text healthText;
	public Text comboText;

	public int health;
	public GameObject GameOver;
	public static bool GameIsActive;
	public GameObject RetryButton;
	public GameObject BarX;
	public static Game Instance;
	// Use this for initialization
	void Start () {
		Instance = this;
		GameStart ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GameStart()
	{
		health = 3;
		healthText.text="health : 3";
		GameIsActive = true;
		GameOver.SetActive (false);
		RetryButton.SetActive (false);
		BarX.gameObject.transform.position = new Vector3 (0,-3.91f,0);
	}
	public void HealthSet()
	{
		health--;
		if (health < 0) 
		{
			GameOver.SetActive (true);
			RetryButton.SetActive (true);
			GameIsActive = false;
		}
		else
		healthText.text="health : "+health;

	}
	public void combohit(int a)
	{
		comboText.text=a+"  combo!";
	}
}
