using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Imran.DataBase;

public class SkinInShop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameplaySettings skinInfo;
    public Image SkinImage;
    public bool isSkinUlocked1;
    [SerializeField] private Text buttonText;
    private void Awake()
    {
        SkinImage.sprite = skinInfo.skinSprite;
        SkinImage.sprite = skinInfo.skins[0].sprite;

        DataBase.SaveActiveSkin(0);
    }
    public void isSkinUlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo.skinDs.ToString()) == 1)
        {
            isSkinUlocked1 = true;
            buttonText.text = "Equip";
        }
      

    }
    public void OnButtonPressed()
    {
        if(isSkinUlocked1)
        {
            FindObjectOfType<SkinManager>().EquipSkin(skinInfo);
        }
        else
        {
           if (FindObjectOfType<PayMoney>().RemoveMoney(skinInfo.skinPrice))
           {
                PlayerPrefs.SetInt(skinInfo.skinDs.ToString(), 1);
                isSkinUlocked();
             
                
           }
        }
    }
}
