using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	// Use this for initialization
	bool ballIsActive;
	public int combo=0;
	Vector3 ballPosition;
	Vector2 ballInitialForce;
	Rigidbody2D rb;
	public GameObject bar;

	void Start () {
		
		ballInitialForce = new Vector2 (200.0f,300.0f);
		ballIsActive = false;
		ballPosition = transform.position;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!ballIsActive && bar != null)
		{
			ballPosition.x = bar.transform.position.x;
			transform.position = ballPosition;
		}
		// Shoot!
		if (Input.GetButtonDown ("Jump") == true) 
		{
			if (!ballIsActive)
			{
				rb.isKinematic = false;
				rb.AddForce(ballInitialForce);
				ballIsActive = !ballIsActive;
			}
		}
		if (ballIsActive && transform.position.y < -5) {
			Game.Instance.HealthSet ();
			if (Game.GameIsActive) {
				combo = 0;
				Game.Instance.combohit (combo);
				ballIsActive = !ballIsActive;
				ballPosition.x = bar.transform.position.x;
				ballPosition.y = -3.45f;
				transform.position = ballPosition;
				rb.isKinematic = true;
			}
			else
				ballPosition.y = -4f;
		}

	}
	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.gameObject.tag == "block") {
			combo++;
			Game.Instance.combohit (combo);
		} else if (hit.gameObject.tag == "Bar") {
			combo = 0;
			Game.Instance.combohit (combo);
		}
	}
}
