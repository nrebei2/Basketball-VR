using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class TimerText : MonoBehaviour
{

    private TextMeshPro Timer;

    [SerializeField]
    public static float TimerLeft = 120.0f;

    public AudioSource Clip;

    public bool Bool = true;
    public GameObject Board;

    // Use this for initialization
    void Start()
    {
        Timer = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        Timer.text = "Time Left: " + TimerLeft.ToString("0") + " Seconds";
        if (TimerLeft <= 0)
        {
            Builder.EndGame();
        }

        if ((Bool == true) && TimerLeft <= 0)
        {
            Buzzer();
        }

        if (Builder.number >= 1 && TimerLeft > 0)
        {
            DecreaseTime();
        }

    }

    public void DecreaseTime()
    {
        TimerLeft -= Time.deltaTime;
    }

    public void Buzzer()
    {
        Bool = false;
        Clip = GetComponent<AudioSource>();
        Clip.Play();
        Instantiate(Board);
    }
}
