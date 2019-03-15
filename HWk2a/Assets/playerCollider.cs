using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {

       
        
        if (col.gameObject.tag == "wall")
        {
            Debug.Log("is coliding");
            float y = transform.position.y;
            var dist = transform.position - col.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position);
            dist.y = 0;
            dist = Vector3.Normalize(dist);
            Raycasttest.stop = true;
            transform.position = transform.position + (dist);
            
        }

       




    }
}
