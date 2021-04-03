using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public Timing timing2;
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        me.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timing2.Ace == true)
        {
            me.SetActive(true);
            Debug.Log("ans");
        }
    }
}
