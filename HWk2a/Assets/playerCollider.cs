using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public static int playerHp = 6;
    int currHp = 6;
    bool FadingOut = false;
    float fadingTime = 5.0f;
    GameObject overlay;
    void Start()
    {
        overlay = GameObject.Find("Overlay");
        overlay.transform.GetChild(0).transform.GetComponent<Image>().CrossFadeAlpha(0, 5.0f, false);
        overlay.transform.GetChild(1).transform.GetComponent<Image>().CrossFadeAlpha(0, 5.0f, false);
    }

    // Update is called once per frame
    void Update()
    {
        if(currHp > playerHp)
        {
            currHp = playerHp;
            overlay.transform.GetChild(1).transform.GetComponent<Image>().CrossFadeAlpha(1, 2.0f, false);
            overlay.transform.GetChild(0).transform.GetComponent<Image>().CrossFadeAlpha(1, 2.0f, false);
            overlay.transform.GetChild(1).transform.GetComponent<Image>().fillAmount += .2f;
            FadingOut = true;

        }
        if (FadingOut)
        {
            
            if (fadingTime > 3.0f)
            {
                ;
            }
            if (fadingTime < 3.0f)
            {

                overlay.transform.GetChild(0).transform.GetComponent<Image>().CrossFadeAlpha(0, 2.0f, false);
                overlay.transform.GetChild(1).transform.GetComponent<Image>().CrossFadeAlpha(0, 2.0f, false);
                FadingOut = false;
                fadingTime = 5.0f;
            }
            fadingTime -= Time.deltaTime;

        }
        

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
