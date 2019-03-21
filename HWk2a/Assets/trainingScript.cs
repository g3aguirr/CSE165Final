using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class trainingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firstSet;
    GameObject tutorialMonitor;
    GameObject displayTextGO;
    TextMeshPro displayText;
    int step = 0;
    void Start()
    {
   
        tutorialMonitor = GameObject.Find("tutorialMonitor");
        displayTextGO = GameObject.Find("displayText");
        displayText = displayTextGO.GetComponent<TextMeshPro>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(firstSet.transform.childCount == 1 && step == 0)
        {
            displayText.text = "Move and Turn with Right Grip";
            step++;
        }
    }
}
