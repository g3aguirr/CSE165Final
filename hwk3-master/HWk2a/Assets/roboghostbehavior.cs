using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roboghostbehavior : MonoBehaviour
{
    GameObject player;

    bool dead;
    public bool hit;

    public float force;
   
    public Vector3 hitPos;
    Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        hit = false;
        diff = player.transform.position - transform.position;


        
    }

    // Update is called once per frame
    void Update()
    {


       
        if (hit)
        {
            //hit = false;
           
        
            dead = true;
            diff = Vector3.Normalize(diff);
            diff.y = -.3f;
            //diff.x = diff.x ;
            //diff.z = diff.z ;
            // transform.GetComponent<Rigidbody>().AddForce(new Vector3(diff.x, .5f, diff.z), ForceMode.Impulse);
           
            transform.GetComponent<Rigidbody>().AddForceAtPosition(-diff/3, hitPos, ForceMode.Force);
        }
     
        if (!dead)
        {
            
            diff = player.transform.position - transform.position;
            transform.position = transform.position + (diff * Time.deltaTime);
        }

        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "desk")
        {
            transform.GetComponent<Rigidbody>().detectCollisions = false;
        }
      
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "desk")
        {
            transform.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
}
