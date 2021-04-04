using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public AudioSource audioSource;

    
    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      Time.timeScale = 1f;
      audioSource.pitch = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
        Time.timeScale += 0.05f;
        audioSource.pitch += 0.05f; 
        audioSource.Play();
    }

    }
    }

