using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject owned;

    public Timing timing1;

    public Between mm1;
    // Start is called before the first frame update
    void Start()
    {
        timing1 = GameObject.FindObjectOfType<Timing>();
    }

    // Update is called once per frame
    void Update()
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
