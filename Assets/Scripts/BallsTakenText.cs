using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallsTakenText : MonoBehaviour
{

    private TextMeshPro BallsTaken;

    [SerializeField]
    public static int BallsTakenNumber = 0;

    // Use this for initialization
    void Start()
    {
        BallsTaken = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        BallsTaken.text = "Balls Taken: " + BallsTakenNumber.ToString();
    }
}
