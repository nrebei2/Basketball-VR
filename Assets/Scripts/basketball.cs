using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketball : MonoBehaviour {

    public AudioSource Clip;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ScoreChecker")
        {
            if (TimerText.TimerLeft <= 0)
            {
                return;
            }
            Debug.Log("KDEN");
            BasketsText.NumberBaskets++;
            Debug.Log(BasketsText.NumberBaskets);
            Clip = GetComponent<AudioSource>();
            Clip.Play();
        }
        Debug.Log("O K I E  DO K  I  E");
    }

}
