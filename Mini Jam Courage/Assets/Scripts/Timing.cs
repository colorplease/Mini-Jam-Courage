using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour
{
    public bool Early = false;
    public bool Late = false;
    public bool Ace = false;

    public bool pressed = false;
    public bool pressed1 = false;



    public Timing timing;



    public Animator Scythe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
            Scythe.SetBool("pressleft", true);
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            pressed1 = true;
            Scythe.SetBool("pressright", true);
        }

        if (pressed == true)
        {
            StartCoroutine("Cool");
        }

        if (pressed1 == true)
        {
            StartCoroutine("Cool2");
        }

        if (Ace == true)
        {
            
            
            
         
            
        }
        else
        {
            
        }
    }

    IEnumerator Cool()
    {
        yield return new WaitForSeconds(0.05f);
        pressed = false;
        Scythe.SetBool("pressleft", false);
    }

     IEnumerator Cool1()
    {
        yield return new WaitForSeconds(0.05f);
        Ace = false;
    }

    IEnumerator Cool2()
    {
        yield return new WaitForSeconds(0.05f);
        pressed1 = false;
        Scythe.SetBool("pressright", false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy" && pressed == true)
        {
           Ace = true;
        }

         
    }

    
        
    

    
}
