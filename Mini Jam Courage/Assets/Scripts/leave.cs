using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leave : MonoBehaviour
{
    
    public GameObject menu;
    public GameObject sonow;
    void Start()
    {
        
    }

   public void mainMenu()
   {
       menu.SetActive(true);
       sonow.SetActive(false);
   }
}
