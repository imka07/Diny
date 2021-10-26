using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Fire : MonoBehaviour
{
    [SerializeField] Image flame;
    Coroutine  Flamecoroutine;
    [SerializeField] Image Jump;
    [SerializeField] Image Lightner;
    [SerializeField] Image ArmorImage;
    Coroutine JumpFx;
   
    Coroutine Armor;
    Coroutine light1;
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        flame.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartFlame()
    {
        if (Flamecoroutine != null) StopCoroutine(Flamecoroutine);
        Flamecoroutine = StartCoroutine(Flame());
    }
    public void StartArmor()
    {

        if (Armor != null) StopCoroutine(Armor);
        Armor = StartCoroutine(Armor1());
    }
    public void StartLightFr()
    {
        if (light1 != null) StopCoroutine(light1);
        light1 = StartCoroutine(Light());
    }
    public void StartJumpFr()
    {
        if (JumpFx != null) StopCoroutine(JumpFx);
        JumpFx = StartCoroutine(JumoFx());
    }
    private IEnumerator Flame()
    {
        flame.fillAmount = 1;


        
        var d = player.GetComponent<D>();
        d.LightButton(false);
        d.LighMen(false);
        float timer = 4;
        d.ArmorSetActive(false);
        d.ChangeSkin(true);
        d.SkinBlue2(false);
        d.FlameMen(true);
   
        while (timer > 0)
        {
            d.Yellow.enabled = false;
            d.sprite.enabled = false;
            d.red.enabled = true;
            timer -= Time.deltaTime;
            flame.fillAmount = timer / 4;
            yield return null;
        }
        flame.fillAmount = 0;
       d.StopFlame();
        d.ChangeSkin2(true);
        d.FlameMen(false);
    
        d.ArmorSetActive(false);
        Flamecoroutine = null;
    }
    private IEnumerator JumoFx()
    {
        var d = player.GetComponent<D>();
        Jump.fillAmount = 1;
        float timer = 3;
        player.GetComponent<D>().JpMen(true);
        while (timer > 0)  
        {
            timer -= Time.deltaTime;
            Jump.fillAmount = timer / 3;
            yield return null;
        }
        Jump.fillAmount = 0;
        player.GetComponent<D>().JpMen(false);
        player.GetComponent<D>().JumpForce = 23;
        
        JumpFx = null;
    }
   
    private IEnumerator Light()
    {
     

        var d = player.GetComponent<D>();
        d.red.enabled = false;
        Lightner.fillAmount = 1;
            float timer = 3;
            d.ArmorSetActive(false);
            d.LighMen(true);
        d.LightButton(true);
        d.SkinBlue(true);
  
      
        
            d.lightButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                d.LighMen(false);
                d.SkinBlue2(false);
            });
            while (timer > 0)
            {
                timer -= Time.deltaTime;
                Lightner.fillAmount = timer / 3;
                yield return null;
           
              
              
            }
            d.ArmorSetActive(false);
        
        d.LighMen(false);
        d.LightButton(false);
        d.SkinBlue2(true);
        Lightner.fillAmount = 0;



            light1 = null;
        
        
    }
    private IEnumerator Armor1()
    {
          
        var d = player.GetComponent<D>();
       

        d.ArMen(true);
        d.Aura(true);
        d.AuraSound(true);
      
      
        d.YellowSkin(true);
        d.LightButton(false);
         d.LighMen(false);
        ArmorImage.fillAmount = 1;
            float timer = 3;
            while (timer > 0)
            {
               
               timer -= Time.deltaTime;
                ArmorImage.fillAmount = timer / 3;
                yield return null;
              
            }
            ArmorImage.fillAmount = 0;
        
        d.Aura(false);
        d.YellowSkin2(true);
        d.StopArmor();
            d.ArMen(false);
      
        Armor = null;

        
    }
      
       
}
