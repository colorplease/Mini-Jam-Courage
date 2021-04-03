using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Timing timing1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

   

    void OnTriggerStay2D(Collider2D other)
    {
         if (other.tag == "Detec" && timing1.pressed == true)
        {
          timing1.Ace = true;
        }
    }

     
}
