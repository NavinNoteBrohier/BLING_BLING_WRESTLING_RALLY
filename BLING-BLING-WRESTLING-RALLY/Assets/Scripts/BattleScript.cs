using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class BattleScript : NetworkBehaviour
{

	public float Maxhealth, Strength;

    [SyncVar]
    private float Health;

    public float DecayTimer;
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
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isServer)
                    Health += Strength;
                else
                    Health -= Strength;
            }


            //            RunDecay();

            if (DecayTimer <= 0) Health = Health < Maxhealth / 2 ? Health += Decay * Time.deltaTime : Health -= Decay * Time.deltaTime;

            DecayTimer = DecayTimer <= 0 ? DecayRate : DecayTimer -= Time.deltaTime;


        }

        UI_Slider.GetComponent<Slider>().value = Health;
	}

    void RunDecay()
    {

    }
}
