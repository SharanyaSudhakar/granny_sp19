using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScript : MonoBehaviour
{

    //private bool rightHandtouched = false;
    //private bool leftHandtouched = false;
    public GameObject righthand,lefthand, granny;
    GameObject fish;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void celebrate()
    {
        if (gameObject.CompareTag("Salmon3"))
        {
            granny.GetComponent<Granny_Behavior>().Clap3();
            granny.GetComponent<Granny_Behavior>().chewing.Play();
            granny.GetComponent<Granny_Behavior>().EatenAndCelebration();
        }
        else if (gameObject.CompareTag("Fish"))
        {
            granny.GetComponent<Granny_Behavior>().Clap2();
            granny.GetComponent<Granny_Behavior>().chewing.Play();
            granny.GetComponent<Granny_Behavior>().EatenAndCelebration();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "right")
        {
           transform.SetParent(other.transform);
        }
        else if(other.gameObject.CompareTag("left"))
        {
            transform.SetParent(lefthand.transform);
        }
        else if (other.gameObject.CompareTag("head"))
        {
            celebrate();
        }
    }
        //if (other.gameObject.CompareTag("PlayerLeftHand"))
        //{
        //    Debug.Log("Left Hand touched");
        //    leftHandtouched = true;
        //    rightHandtouched = false;
        //    leftHand = other;
        //    rightHandDisable.tag = "Player";
        //}
        //else if (other.gameObject.CompareTag("PlayerRightHand"))
        //{
        //    Debug.Log("Right Hand touched");
        //    rightHandtouched = true;
        //    leftHandtouched = false;
        //    rightHand = other;
        //    leftHandDisable.tag = "Player";
        //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("PlayerRightHand"))
    //    {
    //        rightHandtouched = false;
    //        leftHandDisable.tag = "PlayerLeftHand";
    //    }
    //    else if (other.gameObject.CompareTag("PlayerLeftHand"))
    //    {
    //        leftHandtouched = false;
    //        rightHandDisable.tag = "PlayerRightHand";
    //    }
    //}

    //private void stickOnToFlipper(Collider whichhand)
    //{
    //    if (whichhand.name == "left_flipper")
    //        this.transform.position = leftholder.position;
    //    else
    //        this.transform.position = rightholder.position;
    //}
}
