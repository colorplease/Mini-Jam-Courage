using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Animator animator;

    public GameObject godhimself;

    public GameObject wegot;
    public GameObject wegot2;
    public GameObject wegot3;
    public GameObject wegot4;

    public GameObject Credits2;

    public GameObject hmf;
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

    public void gamers1()
    {
        Credits2.SetActive(true);
        hmf.SetActive(false);

    }

    public void ungamers()
    {
        Credits2.SetActive(false);
        hmf.SetActive(true);
    }

  

    IEnumerator gamers()
    {
        animator.SetBool("audio", true);
        godhimself.SetActive(true);
        yield return new WaitForSeconds(1f);
        wegot.SetActive(true);
        wegot2.SetActive(true);
        wegot3.SetActive(true);
        wegot4.SetActive(true);
        yield return new WaitForSeconds(4f);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator gaming()
    {
        animator.SetBool("audio", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
