using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasketsText : MonoBehaviour {

    private TextMeshPro Baskets;

    [SerializeField]
    public static int NumberBaskets = 0;

	// Use this for initialization
	void Start () {
        Baskets = GetComponent<TextMeshPro>();

    }
	
	// Update is called once per frame
	void Update () {
        Baskets.text = "Baskets: " + NumberBaskets.ToString();
	}
}
