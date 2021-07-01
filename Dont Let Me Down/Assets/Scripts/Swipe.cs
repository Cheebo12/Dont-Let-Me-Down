using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startpos, endpos, direction;
    float starttime, endtime, interval;

    [SerializeField]
    float throwforce;
    Vector2 gravity = new Vector2(0f,5f);
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
            starttime = Time.time;
            startpos = Input.GetTouch(0).position;

            Debug.Log("start pos "+startpos);
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
            endtime = Time.time;
        
            interval = endtime - starttime;

            endpos = Input.GetTouch(0).position;
        
            Debug.Log("End pos "+endpos);
            
            direction = startpos - endpos;
            Vector2 ballforce = new Vector2(direction.x,direction.y);
            rb.isKinematic = false;
            rb.AddForce(-ballforce*throwforce*Time.deltaTime, ForceMode.Impulse);
        }

        rb.AddForce(-gravity*Time.deltaTime, ForceMode.Impulse);
        Debug.Log(rb.AddForce(-gravity*Time.deltaTime, ForceMode.Impulse));
    }
}
