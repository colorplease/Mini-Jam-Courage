using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hm : MonoBehaviour
{

    public Timing timingtrio;
    public Animator hm1;
 
    // Start is called before the first frame update
    void Start()
    {
       hm1.SetFloat("animSpeed", timingtrio.speed2);
    }

    // Update is called once per frame
    void Update()
    {
      hm1.SetFloat("animSpeed", timingtrio.speed2);
    }
}
