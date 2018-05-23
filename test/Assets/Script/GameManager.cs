using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private GameObject player;
    public GameObject stageClearMessage;
    public GameObject gameOverMessage;
    public GameObject timer;
    public GameObject retryButton;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player.GetComponent<Player>().isGoal)
        {
            stageClearMessage.SetActive(true);
            player.GetComponent<Player>().enabled = false;
            timer.GetComponent<Timer>().enabled = false;
        }
        else
        {
            stageClearMessage.SetActive(false);
        }
        if (player.GetComponent<Player>().isGameOver)
        {
            gameOverMessage.SetActive(true);
            player.GetComponent<Player>().enabled = false;
            timer.GetComponent<Timer>().enabled = false;
            retryButton.SetActive(true);
        }
        else
        {
            gameOverMessage.SetActive(false);
        }
	}

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
