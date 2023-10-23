using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Imran.DataBase;

public class D : MonoBehaviour
{
    public AudioSource auraSound;
    Rigidbody2D rb;
    
    public SpriteRenderer sprite;
    public float JumpForce = 3f;
    bool isGround = false;
    public int tryCount;
    public float health;
    Animator anim;
    [SerializeField] private Image flame;
    public GameObject auraLight;
    public GameObject pauseButton;
    BoxCollider2D bx;
    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite alive, dead;
    public GameObject oas;
    [SerializeField] GameObject losepanel;
    [SerializeField] private D d;
    [SerializeField] private AudioSource hit;
    [SerializeField] private GameObject[] tr;
    [SerializeField] private ParticleSystem heartEx;
    [SerializeField] private AudioSource coinSound;
    [SerializeField] private AudioSource flameSound;
    [SerializeField] private AudioSource WinSound;
    [SerializeField] private AudioSource heartSound;
    [SerializeField] private AudioSource FasterSound;
    [SerializeField] private AudioSource SlowerMusic;
    [SerializeField] private AudioSource JumpSoundEffect;
    [SerializeField] private Text scoreText;
    public int speedFactor;
    public int SlowFactor;
    public int jumpFactor;
    public float score = 0;
    public GameObject coin;
    public float damage;
    public bool isRed;
    public bool isBlue;
    public bool isYellow;
    public bool isGreen;
    public GameObject flameAura;
     public  Transform groundCheck;
    public float groundRaduis;
    public LayerMask groundLayer;
    [SerializeField] private GameObject flameMen;
    [SerializeField] private GameObject Jp;
    [SerializeField] private GameObject Ar;
    public GameObject lightMen;
    [SerializeField] private GameObject WinPanel;
    private SpriteRenderer[] ch_sprites;
    private bool flame1 = false;
    private bool Jump1 = false;
    private bool light1 = false;
    private bool armor1 = false;
    public SpriteRenderer red;
    public SpriteRenderer blue;
    public SpriteRenderer Yellow;
    public Animator redAnim;
    private Fire fr;
    public Shaker shake1;
    public GameObject aura;
    private CheckPoint currentCheckPoint = null;
    public ParticleSystem explosion;
    GameObject Bird;
    [SerializeField] private GameObject pressECanvas, killThem, protectYourself;
    public GameObject lightButton;
    [SerializeField] private GameObject LightEx;
    public static D Instance { get; set; }
    // Start is called before the first frame update
    void Start()
    {
     
        pressECanvas.SetActive(false);
        killThem.SetActive(false);
        protectYourself.SetActive(false);
        pauseButton.SetActive(true);
        tryCount = PlayerPrefs.GetInt("tryCount");
        auraLight.SetActive(false);
        sprite = GetComponentInChildren<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        health = 3;
        oas.SetActive(true);
        Instance = this;
        fr = FindObjectOfType<Fire>();
        losepanel.SetActive(false);
        anim = GetComponent<Animator>();
        bx = GetComponent<BoxCollider2D>();
        d = GetComponent<D>();
        ch_sprites = GetComponentsInChildren<SpriteRenderer>();
        red.enabled = false;
        blue.enabled = false;
        sprite.enabled = true;
        Yellow.enabled = false;
        isRed = false;
        isBlue = false;
        isGreen = true;
        isYellow = false;
        flameMen.SetActive(false);
        flameAura.SetActive(false);
        Jp.SetActive(false);
        Ar.SetActive(false);
        lightMen.SetActive(false);
        Yellow.enabled = false;
        aura.SetActive(false);
        switch (DataBase.LoadStartBonus())
        {
            case 0:
                break;
            case 1:
                fr.StartFlame();
                DataBase.SaveStartBonus(0);
                break;
            case 2:
                fr.StartLightFr();
                DataBase.SaveStartBonus(0);
                break;
            case 3:
                fr.StartArmor();
                armor1 = true;
                DataBase.SaveStartBonus(0);
                break;
        }
       
    }
    // Update is called once per frame
    void Update()
    {


     
        var s = FindObjectOfType<Score>();
        s.ScoreIn(true);
        if (health > 3)
            health = 3;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = alive;
            }
            else
            {
                hearts[i].sprite = dead;
            }
            if(health == 0)
            {
               
                Die();
            }
   
        }  
    }
    
    
    private void FixedUpdate()
    {
        CheckGround();
    }
    [SerializeField] private float groundLengh = 0.6f;
    private void CheckGround()
    {


        isGround = false;
        Collider2D[] collider = Physics2D.OverlapCircleAll(groundCheck.position, groundRaduis, groundLayer);
        if (collider.Length > 0)
            isGround = true;
    }

    private bool _isDead = false;
    private void Die()
    {
        if (!_isDead)
        {
            pauseButton.SetActive(false);
            var s = FindObjectOfType<Score>();
            s.ScoreIn(false);
            Time.timeScale = 0;
            health = 0;
            losepanel.SetActive(true);
            oas.SetActive(false);
            _isDead = true;
        }
    }
    
    public void Respawn()
    {
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        var s = FindObjectOfType<Score>();
        s.ScoreIn(true);
        transform.position = new Vector3(currentCheckPoint.playerSpawnPosition.x, currentCheckPoint.playerSpawnPosition.y, 0);
        health = 3;
        oas.SetActive(true);
      
        losepanel.SetActive(false);
        
    }
   
    public void GetDamage(float damage)
    {
        if(!armor1)
        {
            health = health - damage;
            hit.Play();
            DamageEffect();
        }
       

        if (health == 0)
        {
            foreach (var h in hearts)
                h.sprite = dead;
            Die();
        }    
         
    }
    public void FlameMen(bool active)
    {
        pressECanvas.SetActive(false);
        pressECanvas.SetActive(false);
        killThem.SetActive(active);
        flameMen.SetActive(active);
    }
    public void FlameAura(bool active)
    {
        flameAura.SetActive(active);
    }
    public void JpMen(bool active)
    {
        Jp.SetActive(active);
    }
    public void ArMen(bool active)
    {
        killThem.SetActive(false);
        pressECanvas.SetActive(false);
        protectYourself.SetActive(active);
        Ar.SetActive(active);
    }
    public void Aura(bool active)
    {
       aura.SetActive(active);
    }
    public void AuraSound(bool active)
    {
        auraSound.Play();
    }
    public void LighMen(bool active)
    {
        pressECanvas.SetActive(false);
        killThem.SetActive(false);
        pressECanvas.SetActive(active);
        lightMen.SetActive(active);
    }
    public void LightButtonActivated(bool active)
    {
        lightButton.SetActive(active);
    }
   
    public void StopFlame()
    {
        flame1 = false;
    }
    public void StopLight()
    {
        light1 = false;
    }
    public void StopJump()
    {
        Jump1 = false;
    }
    private void DamageEffect()
    {
        for (int i = 0; i < ch_sprites.Length; i++)
        {
            ch_sprites[i].color = new Color(1, 0.5f, 0.5f);
        }
        Invoke("SetWhiteColor", 0.05f);
    }

    private void SetWhiteColor()
    {
        for (int i = 0; i < ch_sprites.Length; i++)
        {
            ch_sprites[i].color = Color.white;
        }
    }
   
    public void Jump()
    {
        if (isGround)
        { 
           rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }

        
    }
    public void StopArmor()
    {
        armor1 = false;
    }
    public void ArmorSetActive(bool active)
    {
        aura.SetActive(active);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "tile")
        {
            Die();
            DamageEffect();
            hit.Play();
            foreach (var h in hearts)
                h.sprite = dead;
        }
       
        
        

    
    }

    public void ChangeSkin(int index)
    {
        switch (index)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:

                break;
        }
    }
    //public void Boom()
    //{

    //    var birds = FindObjectsOfType<Bird>();

    //    if (birds.Length > 0)
    //    {
    //        for (int i = 0; i < birds.Length; i++)
    //        {
    //            var s = FindObjectOfType<Score>();
    //            s.score1 += 5;
    //            print(i);
    //            birds[i].Die();
    //            Instantiate(LightEx, birds[i].transform.position, Quaternion.identity);

    //        }
    //    }
    //}
    //public bool inputLight = false;
    //private void InputLight()
    //{
    //    if(Input.GetKeyDown(KeyCode.E) && isBlue == true)
    //    {
    //        ShakerCinemachine.Instance.Shaker(5, 0.5f);
    //        Boom();
    //        inputLight = true;
    //    }
    //}
 
    public void ChangeSkin()
    {
        
        isRed = true;
        flameAura.SetActive(true);
            red.enabled = true;
            sprite.enabled = false;
        blue.enabled = false;
       
    }
    public void YellowSkin()
    {
        sprite.enabled = false;
     
        isYellow = true;
        Yellow.enabled = true;
        blue.enabled = false;
        red.enabled = false;
    }
    public void YellowSkin2()
    {
       
        isYellow = false;
        Yellow.enabled = false;
        blue.enabled = false;
        sprite.enabled = true;
        red.enabled = false;
    }
    public void SkinBlue()
    {
        auraLight.SetActive(true);
        isBlue = true;
        blue.enabled = true;
        sprite.enabled = false;
        red.enabled = false;
    }
    public void SkinBlue2()
    {
        auraLight.SetActive(false);
        isBlue = false;
        blue.enabled = false;
        sprite.enabled = true;
        red.enabled = false;
    }
    public void ChangeSkin2()
    {

        isRed = false;
        red.enabled = false;
        flameAura.SetActive(false);
        sprite.enabled = true;
    }
    private void PickFlame()
    {
        oas.SetActive(true);
        aura.SetActive(false);
        flame1 = true;
        flameSound.Play();
        fr.StartFlame();
    }
    private void PickLight()
    {
        oas.SetActive(true);
        light1 = true;
        flameAura.SetActive(false);
        aura.SetActive(false);
        flameSound.Play();
        fr.StartLightFr();
    }
    private void PickJump()
    {
        JumpSoundEffect.pitch = Random.Range(0.9f, 1f);
        JumpSoundEffect.Play();
        fr.StartJumpFr();
    }
    private void Bomb()
    {
        if (!isYellow)
            health -= 1;
    }
    private void PickArmor()
    {     
        fr.StartArmor();
       
        flameAura.SetActive(false);
        armor1 = true;
    }
    private void PickHeart()
    {
        health += 1;
        heartSound.Play();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        ChangeSkin(DataBase.LoadActiveSkin());
        if (collision.gameObject.tag == "Bird")
        {
            ShakerCinemachine.Instance.Shaker(5, 0.5f);
            if (isRed)
            {
                var s = FindObjectOfType<Score>();
                s.score1 += 5;
                collision.GetComponent<Bird>().Die();
            }
        }

        if (collision.tag == "CheckPoint")
        {
            print("CheckPoint");
            currentCheckPoint = collision.GetComponent<CheckPoint>();
        }
        if(collision.gameObject.tag == "Bomb")
        {
            ShakerCinemachine.Instance.Shaker(5, 0.5f);
            Bomb();
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "heart")
        {
            PickHeart();
            Instantiate(heartEx, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Armor")
        {

            PickArmor();

            Destroy(collision.gameObject);
           
        }
       
        if (collision.gameObject.tag == "Flame")
        {
            PickFlame();

            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.tag == "light")
        {

            PickLight();
            Destroy(collision.gameObject);
        }  
       if(collision.gameObject.tag == "JumpFx")
       {
            PickJump();
            Destroy(collision.gameObject);
           
       }
    }


}
