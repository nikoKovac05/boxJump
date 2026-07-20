using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class healthDropper : MonoBehaviour
{
    private bool isDead = false;
    private float endtime = 2f;
    public GameObject endScreen;
    
    void Start()
    {
        isDead = false;
        
        endScreen = GameObject.Find("gameOver");
        endScreen.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            isDead = true;
        }
     }   

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isDead)
        {
            
            endtime -= Time.deltaTime;
            endScreen.SetActive(true);
            if (endtime <= 0)
            {
                SceneManager.LoadScene("menuScreen");
            }
        }
    }
}
