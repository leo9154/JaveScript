#pragma strict

var lifepoint : int;
private var numberOfHits : int;


function Start () {

	lifepoint=3;
	numberOfHits=0;
}

function Update () {

}

function OnCollisionEnter2D(hit : Collision2D )
	{
		if (hit.gameObject.tag == "ball")
		{
			numberOfHits++;
			if (numberOfHits == lifepoint) {
				Destroy (gameObject);

			}
				
		}
	}
