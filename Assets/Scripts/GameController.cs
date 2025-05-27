using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public bool isStart;
    public bool isEndGame;
    int gamePoint = 0;
    
    public Text textPoint;
    public TextMeshProUGUI textEndGameScore;
    public GameObject panelEndGame;
    public GameObject panelStart;
    public Button btnRestart;
    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        panelEndGame.SetActive(false);
        isStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButton(0) && isStart )
            {
                StartGame();

            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Time.timeScale = 1;
                panelStart.SetActive(false);
            }
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        StartGame();
    }
    public void GetPoint()
    {
        gamePoint++;
        textPoint.text = "Score: " + gamePoint.ToString();
        if (gamePoint == 0)
        {
            textEndGameScore.text = "Your SCore" + "\n" + gamePoint.ToString("0");
        }
        else
        {
            textEndGameScore.text = "Your SCore" + "\n" + gamePoint.ToString();
        }
        

    }
    public void RestartButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnClick;
    }

    public void RestartButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnHover;
    }

    public void RestartButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnIdle;
    }

    public void EndGame()
    {
        isStart = false;
        isEndGame = true;
        Time.timeScale = 0;
        panelEndGame.SetActive(true);
    }
   
}
