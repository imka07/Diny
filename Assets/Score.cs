using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pl;
    public Text score;
    public float score1;
    public bool o;
    private int factor;
    public CanvasGroup[] group;
    public GameObject p;
    private DownMove PlatFormSpeed;
    void Start()
    {
     
        

    }
    private void Update()
    {
        var d = FindObjectOfType<DownMove>();
        if (score1 > 30)
        {
            group[0].alpha += Time.deltaTime;
            d.speed = 6.1f;
        }
        if (score1 > 100)
        {
            d.speed = 6.3f;
            group[1].alpha += Time.deltaTime;
        }
        if (score1 > 200)
        {
            d.speed = 6.5f;
            group[2].alpha += Time.deltaTime;
        }
        if (score1 > 300)
        {
            d.speed = 6.7f;
            group[3].alpha += Time.deltaTime;
        }
        if (score1 > 400)
        {
            d.speed = 6.8f;
            group[4].alpha += Time.deltaTime;
        }
        if (score1 > 450)
        {
            d.speed = 6.9f;
            group[5].alpha += Time.deltaTime;
        }
        if (score1 > 500)
        {
            d.speed = 7;
            group[6].alpha += Time.deltaTime;
        }
        if (score1 > 800)
        {
            d.speed = 7.3f;
            group[7].alpha += Time.deltaTime;
        }


    }
    public void ScoreIn(bool active)
    {
        PlayerPrefs.SetFloat("score", score1);
        score.text = score1.ToString("0");
        score1 += Time.deltaTime;
    }
   
   
   
}
