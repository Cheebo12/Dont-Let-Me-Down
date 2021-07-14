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
       

    
    }
}
