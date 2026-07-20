using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

public class playerSkin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Sprite[] skinovi;
    [SerializeField] int skinId;
    [SerializeField] Sprite skin;
    
    void Start()
    {
        
        skinId = PlayerPrefs.GetInt("skinId");
        skin = skinovi[skinId];
        gameObject.GetComponent<SpriteRenderer>().sprite=skin;
    }

    
}
