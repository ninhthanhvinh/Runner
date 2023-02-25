using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static int point;
    public TextMeshProUGUI pointTMP;

    public GameObject completeSceneUI;
    public TextMeshProUGUI winPointTMP;

    public GameObject loseSceneUI;
    public TextMeshProUGUI losePointTMP;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointTMP.SetText(point.ToString());
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;

        //Hiện màn hình Pause
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;

        //Ẩn màn hình Pause
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void NextStage()
    {
        var i = SceneManager.GetActiveScene().buildIndex + 1;
        if (i <= 2)
            SceneManager.LoadScene("Stage" + i.ToString());
        else
            SceneManager.LoadScene("Stage" + Random.Range(1,3).ToString());

        Time.timeScale = 1f;
    }

    public void CompleteScene()
    {
        PauseGame();
        //Kích hoạt UI CompleteScene
        winPointTMP.SetText(point.ToString());
        completeSceneUI.SetActive(true);

    }

    public void LoseScene()
    {
        PauseGame();
        //Kích hoạt UI LoseScene
        losePointTMP.SetText(point.ToString());
        loseSceneUI.SetActive(true);
    }

    public void Home()
    {
        SceneManager.LoadScene("StartMenu");
    }
}