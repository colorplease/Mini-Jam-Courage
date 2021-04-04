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
    public bool dmg = false;



    public Timing timing;



    public Animator Scythe;
    public Animator shakea;

    public Animator man;
    
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

        if (dmg == true)
        {
            shakea.SetBool("damage", true);
            man.SetBool("hit", true);
            StartCoroutine("beatisnon");
               StartCoroutine("beatisnon1");
            dmg = false;
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

    IEnumerator beatisnon()
    {
        yield return new WaitForSeconds(0.1f);
        shakea.SetBool("damage", false);
        
    }

    IEnumerator beatisnon1()
    {
        yield return new WaitForSeconds(0.2f);
        man.SetBool("hit", false);
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy" && pressed == true)
        {
           Ace = true;
        }

         
    }

    
        
    

    
}
