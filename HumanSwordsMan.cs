using UnityEngine;
using System.Collections;

public class HumanSwordsMan : SwordsMan {

	public HumanSwordsMan ()
	{
		Armor = 1;
		Health = 45;
		CurrentHealth = 45;
		Atack = 5;
	}
	// Use this for initialization
	void Start () {
		XCoord = transform.position.x;
		YCoord = transform.position.y;
		Speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
	//if (Input.mousePosition==
	}
}
