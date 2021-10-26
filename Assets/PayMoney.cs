using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayMoney : MonoBehaviour
{
    // Start is called before the first frame update
    public int Money;
    public bool RemoveMoney(int moneyToRem)
    {
        if(Money >= moneyToRem)
        {
            Money -= moneyToRem;
            return true;
        }
        else
        {
            return false;
        }
    }
}
