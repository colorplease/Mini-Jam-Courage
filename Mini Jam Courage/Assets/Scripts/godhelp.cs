using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godhelp : MonoBehaviour
{
   public GameObject sounds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(gaming());
        sounds.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator gaming()
    {
        yield return new WaitForSeconds(1f);
        sounds.SetActive(true);
    }
}
