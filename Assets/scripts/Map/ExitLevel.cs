using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    
    GameObject exitScreen; // Assign this in the Unity Editor
    private float remainingTime = 2f;
    private bool timerStarted = false;

    

    private void Start()
    {
        
        exitScreen = GameObject.Find("gameComplete");
        exitScreen.SetActive(false);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming player is tagged as "Player"
        {
            timerStarted = true;
        }
    }

    private void Update()
    {
        if (timerStarted)
        {
            remainingTime -= Time.deltaTime;
            exitScreen.SetActive(true);
            if (remainingTime <= 0)
            {
                SceneManager.LoadScene("menuScreen");
                return;
            }
           
            
        }
    }
}
