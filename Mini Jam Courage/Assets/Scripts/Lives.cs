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

    public Animator sussy;
    public Animator sus;

    // Start is called before the first frame update
    void Update()
    {
        if(livesAmount == 0)
        {
            StartCoroutine("godme");
        }
        life.text = "Lives:" + livesAmount.ToString();
    }

    IEnumerator godme()
    {
        sus.SetBool("mass", true);
        sussy.SetBool("wamen", true);
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
