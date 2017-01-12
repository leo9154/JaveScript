using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	// Use this for initialization
	public int lifepoint;
	private int numberOfHits;
	public static block Instance;
	float time;
	void Start () {
		Instance = this;
		lifepoint = 3;
		numberOfHits = 0;
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.gameObject.tag == "ball")
		{
			numberOfHits++;
			if (numberOfHits == lifepoint) {
				/*gameObject.SetActive (false);
				gameObject.SetActive (true);
				numberOfHits = 0;*/
				Destroy (gameObject);

			}
				
		}
	}
	public void BlockReset()
	{
		
	}

}
