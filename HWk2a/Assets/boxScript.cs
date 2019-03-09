using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public bool isHeld;
    GameObject leftHand;
    // Start is called before the first frame update
    void Start()
    {
        isHeld = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHand = GameObject.Find("hand_right");
    }

    void OnTriggerStay(Collider col)
    {
        Debug.Log("collided");
        if (col.gameObject.tag == "left")
        {
            if (leftHand.transform.GetComponent<Raycasttest>().isHolding)
            {
                transform.position = col.gameObject.transform.position;
                transform.rotation = col.gameObject.transform.rotation;
            }
            //firstSet.transform.FindChild("protoroboghost").
        }



    }
}
