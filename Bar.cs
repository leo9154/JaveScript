using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow))
		if(gameObject.transform.position.x<7.6)
			gameObject.transform.position += new Vector3 (0.25f, 0,0);
		if(Input.GetKey(KeyCode.LeftArrow))
		if(gameObject.transform.position.x>-7.6)
			gameObject.transform.position += new Vector3 (-0.25f, 0,0);
	}
}
