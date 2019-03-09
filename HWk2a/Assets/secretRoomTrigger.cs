using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretRoomTrigger : MonoBehaviour
{
	Collider m_ObjectCollider;
    // Start is called before the first frame update
    void Start()
    {
        m_ObjectCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (butterfly.RED == true && fish.BLUE == true && skull.GREEN == true)
		{
			m_ObjectCollider.isTrigger = true;
			// Debug.Log("ALLRIGHT: "+GameObject.GetComponent<BoxCollider>().isTrigger);
		}
    }
}
