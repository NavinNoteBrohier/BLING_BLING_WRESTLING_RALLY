using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleScript : MonoBehaviour {

	public float Maxhealth, Strength;
	private float Health, DecayTimer;
	public float Decay, DecayRate;
	public GameObject UI_Slider;

	private bool Active;

	// Use this for initialization
	void Start ()
	{
		Health = Maxhealth /2;
		DecayTimer = DecayRate;
		Active = false;
	}
	
	// Update is called once per frame
	void Update ()
	{


		if (Input.GetKeyDown(KeyCode.Space))
		{
			Health += Strength;
		}
		else
		{
			if (DecayTimer <= 0) Health = Health < Maxhealth / 2 ? Health += Decay * Time.deltaTime : Health -= Decay * Time.deltaTime;

			DecayTimer = DecayTimer <= 0 ? DecayRate : DecayTimer -= Time.deltaTime;
		}




		UI_Slider.GetComponent<Slider>().value = Health;
	}
}
