using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public AudioSource audioSource;
    public Timing timing1;

    
    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      Time.timeScale = 1f;
      audioSource.pitch = 1f;
    timing1 = GameObject.FindObjectOfType<Timing>();
    
    Time.timeScale = 0.95f;
    audioSource.pitch = 0.95f;

    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
        Time.timeScale += 0.04f;
        audioSource.pitch += 0.05f; 
        timing1.speed += 0.05f;
        audioSource.Play();
    }

    }
    }

