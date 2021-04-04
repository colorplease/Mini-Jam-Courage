using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Animator animator;
    public void StartGame()
    {
        StartCoroutine(gamers());
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void RetryGame()
    {
        StartCoroutine(gaming());
    }

    IEnumerator gamers()
    {
        animator.SetBool("audio", true);
        yield return new WaitForSeconds(2f);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    IEnumerator gaming()
    {
        animator.SetBool("audio", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
