using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public bool Bool = true;

    public AudioSource Clip;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Bool == true) && (Builder.number >= 1))
        {
            PlayMusic();
        }
    }

    public void PlayMusic()
    {
        Bool = false;
        Clip = GetComponent<AudioSource>();
        Clip.Play();
    }


}
