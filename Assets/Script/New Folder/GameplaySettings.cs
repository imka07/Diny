using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Gameplay Settings", menuName = "Gameplay Settings", order = 51)]

public class GameplaySettings : ScriptableObject
{
    public Skin[] skins;

    [System.Serializable]
    public class Skin
    {
        public string skinName;
        public Sprite sprite;
        public int skinPrice;
    }

    public enum SkinDs {green, red, yellow }
    public SkinDs skinDs;
    public Sprite skinSprite;
    public int skinPrice;

    
   

}
