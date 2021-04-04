using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Between : MonoBehaviour
{

    public Timing timing3;

    public bool Ace1;
    public Between btw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timing3.Ace == true)
        {
            Ace1 = true;
        }
    }
}
