using System.Drawing.Text;
using TMPro;
using UnityEngine;

public class shop : MonoBehaviour
{
    [SerializeField] GameObject []text;

    
    
    public void setSkin(int skinId)
    {
        
        int coins = PlayerPrefs.GetInt("coins");  
        switch (skinId)
        {
            case 0:                
                equipSkin(skinId);
            break;

            case 1:
                if(PlayerPrefs.GetInt("s"+skinId) == 1)
                {
                    equipSkin(skinId);
                }
                else
                {
                    buySkin(100,coins,skinId);
                }
            break;

            case 2:
                if(PlayerPrefs.GetInt("s"+skinId) == 1)
                {
                    equipSkin(skinId);
                }
                else
                {
                    buySkin(200,coins,skinId);
                }
            break;

            case 3:
                if(PlayerPrefs.GetInt("s"+skinId) == 1)
                {
                    equipSkin(skinId);
                }
                else
                {
                    buySkin(300,coins,skinId);
                }
            break;
        }
        
    }
    private void equipSkin(int skinId)
    {
        PlayerPrefs.SetInt("skinId", skinId);
        text[skinId].GetComponent<TextMeshPro> ().text = "equip";
    }
    private void buySkin(int price,int coins,int skinId)
    {
        if(coins < price)
        {
            coins=-price;
            PlayerPrefs.SetInt("coins",coins);
            PlayerPrefs.SetInt("s"+skinId,1);
        }
    }
}
