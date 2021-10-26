using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Imran.DataBase
{
    public static class DataBase
    {
        public static string ACTIVE_SKIN_KEY = "ActiveSkin";
        public static string START_BONUS = "StartBonus";

        public static void SaveActiveSkin(int index)
        {
            PlayerPrefs.SetInt(ACTIVE_SKIN_KEY, index);
        }

        public static int LoadActiveSkin()
        {
            return PlayerPrefs.GetInt(ACTIVE_SKIN_KEY, 0);
        }

        public static void SaveStartBonus(int index)
        {
            PlayerPrefs.SetInt(START_BONUS, index);
        }

        public static int LoadStartBonus()
        {
            return PlayerPrefs.GetInt(START_BONUS, 0);
        }
    }
}
