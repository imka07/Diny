using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static Sprite equipSpr;

    public void EquipSkin(GameplaySettings skinInfo)
    {
        equipSpr = skinInfo.skinSprite;
    }
}
