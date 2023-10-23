using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3;
    SpriteRenderer sprite;
    public float damage = 1;
    public float lifeTime;

    public static Bird Instance { get; set; }
   
    public ParticleSystem birdEx;

   

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(0.1f, 1.5f).SetEase(Ease.InOutSine).SetLoops(5, LoopType.Yoyo);
        sprite = GetComponentInChildren<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Instance = this;      
    }

  
    

    // Update is called once per frame
    void Update()
    {
       
       transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);


        Destroy(this.gameObject, lifeTime);
        
    }
    
    public void Die()
    {
        Destroy(this.gameObject);
        
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == D.Instance.gameObject)
        {
            if (collision.GetComponent<D>().isRed == false)
            {
                
                D.Instance.GetDamage(damage);
                
            }
            
            
                
            


           else
           {
                Instantiate(birdEx, transform.position, Quaternion.identity);
                
                
           }
                
            

        }

    }
}
