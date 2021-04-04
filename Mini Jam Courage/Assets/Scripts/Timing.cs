using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timing : MonoBehaviour
{
    public bool Early = false;
    public bool Late = false;
    public bool Ace = false;

    public bool Ace1 = false;

    public bool pressed = false;
    public bool pressed1 = false;
    public bool dmg = false;

    public bool playHit = false;


    public float speed = 1f;
    public float speed2 = 1f;

    public Lives lives;

    public Timing timing;


    public Animator Scythe;
    public Animator shakea;

    public Animator man;

     public AudioSource audioSource;

    public AudioClip pog;
    public AudioClip sans;
    
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        Application.targetFrameRate = 70;
   
      
=======
        Application.targetFrameRate = 60;

        lives = GameObject.Find("Lives").GetComponent<Lives>();
>>>>>>> Stashed changes
    }

    void Awake()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
            Scythe.SetBool("pressleft", true);
             audioSource.PlayOneShot(pog);
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            pressed1 = true;
            Scythe.SetBool("pressright", true);
             audioSource.PlayOneShot(pog);
        }

        if (pressed == true)
        {
            StartCoroutine("Cool");
            playHit = true;
            
        }

        if (pressed1 == true)
        {
            StartCoroutine("Cool2");
            playHit = true;
        }

       

        if (dmg == true)
        {
            shakea.SetBool("damage", true);
            man.SetBool("hit", true);
            StartCoroutine("beatisnon");
               StartCoroutine("beatisnon1");
<<<<<<< Updated upstream
               audioSource.PlayOneShot(sans);
=======
            lives.livesAmount--;
>>>>>>> Stashed changes
            dmg = false;
        }

       
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
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

     IEnumerator Cool69()
    {
        yield return new WaitForSeconds(0.05f);
        Ace1 = false;
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

        if (other.tag == "Enemy" && pressed1 == true)
        {
            Ace1 = true;
        }

        
         
    }

    
        
    

    
}
