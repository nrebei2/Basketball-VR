using NewtonVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour {
	public GameObject Obj;
	public float Dis = 0.5f;

    //bool RunOnce = true;

    public Vector3 position;
   
    public GameObject instance;

    public static GameObject[] InstanceArr = new GameObject[100];

    public static int number = 0;

    public AudioClip Clip;

 

    public void Start()
    {
        //Board = GameObject.FindGameObjectWithTag("Canvas");
        InstanceArr[0] = this.gameObject;
        
    }

    public void Update() {

        //if (number >= 4)
        //{
            //Destroy(InstanceArr[number - 4]);
        //}

        if (InstanceArr[number] == null)
        {
            return;
        }    


        if (!InstanceArr[0] || Vector3.Distance(InstanceArr[number].transform.position, position) > Dis)
        {
            BuildOne();
        }
	}

    public void BuildOne()
    {

        number += 1;
        BallsTakenText.BallsTakenNumber++;
        InstanceArr[number] = Instantiate(Obj, position, transform.rotation);
        AudioSource.PlayClipAtPoint(Clip, InstanceArr[number].transform.position, 0.7f);
        Destroy(InstanceArr[number].GetComponent("NVRInteractableItem"));
        InstanceArr[number].AddComponent<NVRInteractableItem>();
    }
    
    public static void EndGame()
    {
        //Destroy(InstanceArr[number-1].GetComponent("Builder"));
        //Destroy(InstanceArr[number-1].GetComponent("basketball"));
       
    }

}
