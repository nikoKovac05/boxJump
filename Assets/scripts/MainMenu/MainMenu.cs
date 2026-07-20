using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    public TextMeshProUGUI coinsText;
    
    public void Start()
    {
        coinsText.text = "coins:"+ PlayerPrefs.GetInt("coins");
    }

    public void PlayGame(string imeMape)
    {

        SceneManager.LoadScene(imeMape);
    }
    public void changeView(GameObject toLoad)
    {
        
        toLoad.SetActive(true);
        gameObject.SetActive(false);
    }
}
