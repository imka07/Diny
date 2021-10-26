using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactys : MonoBehaviour
{
    [SerializeField] private float damage;
    private bool isGround;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == D.Instance.gameObject)
        {
            
            D.Instance.GetDamage(damage);


        }
    }
    
    
}
