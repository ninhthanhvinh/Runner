using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStartMenu : MonoBehaviour
{
    int i;
    private void Start()
    {
        FindObjectOfType<AudioManager>().PlayMusic("Reality");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChooseLevel1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void ChooseLevel2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void SetMusic(int index)
    {
        i = index;
    }
    public void PlayMusic()
    {
        if (i == 0)
            FindObjectOfType<AudioManager>().PlayMusic("Reality");
        else if (i == 1)
            FindObjectOfType<AudioManager>().PlayMusic("OogwayAscend");
        else if (i == 2)
            FindObjectOfType<AudioManager>().PlayMusic("YLIAOst");
        else if (i == 3)
            FindObjectOfType<AudioManager>().PlayMusic("TLS");
    }
}
