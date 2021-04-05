using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public Text life;
    Timing lifeCounter;
    public int livesAmount = 3;

    // Start is called before the first frame update
    void Update()
    {
        if(livesAmount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        life.text = "Lives:" + livesAmount.ToString();
    }
}
