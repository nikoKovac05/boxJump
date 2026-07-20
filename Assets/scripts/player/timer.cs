using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    private float endtime = 2f;
    public GameObject endScreen;
    private void Start()
    {
        //endScreen = GameObject.Find("gameOver");
        //endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0) {
            remainingTime -= Time.deltaTime;
        }
        if (remainingTime < 0)
        {
            remainingTime = 0;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text= string.Format("{0:00}:{1:00}", minutes, seconds);


        if (remainingTime == 0)
        {
            endtime-=Time.deltaTime;
            endScreen.SetActive(true);
            if (endtime <= 0)
            {
                SceneManager.LoadScene("menuScreen");
            }

        }
    }
}
