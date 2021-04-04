using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject owned;

    public Timing timing1;

    public Animator shakea;

   
    // Start is called before the first frame update
    void Start()
    {
        timing1 = GameObject.FindObjectOfType<Timing>();
   
      
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Detec")
        {
            Destroy(gameObject);
           timing1.dmg = true;
        }

        if (other.tag == "good god")
        {
            timing1.Ace = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "good god")
        {
            if (timing1.Ace == true)
        {
          GameObject effect = Instantiate(owned, transform.position, Quaternion.identity);
          Destroy(effect , 5f);
          Destroy(gameObject);
          Debug.Log("dude");
          timing1.Ace = false;
  
        }
        }
      
    }


    

   

   
     
}
