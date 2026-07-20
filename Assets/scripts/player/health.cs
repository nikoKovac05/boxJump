using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    private bool isDead;
    private float Health;
    public float startHealth = 1;
    public Image healthBar;
    private float endtime = 2f;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        Health = startHealth;
        //endScreen = GameObject.Find("gameOver");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Health -= 1;
            
            healthBar.rectTransform.sizeDelta = new Vector2(500*(Health / startHealth), 50);
            if (Health <= 0)
            {

                isDead = true;
            }
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
