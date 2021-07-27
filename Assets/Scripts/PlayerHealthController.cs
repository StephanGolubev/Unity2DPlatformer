using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    public int currentHealth, maxHealth;
    public float InvincibleTime;
    private float InvincibleCounter;
    private SpriteRenderer theSR;


    private void Awake() {
       instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InvincibleCounter > 0)
        {
            InvincibleCounter -= Time.deltaTime;
            if (InvincibleCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }
    }
    
    public void DealDamege(){
        if (InvincibleCounter <= 0)
        {
        currentHealth--; 

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            // gameObject.SetActive(false);
            LevelManager.instance.RespondPlayer();
        }else
        {
            InvincibleCounter = InvincibleTime;
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
        }

        UICorntroller.instance.UpdateHealthDisplay();
        }
    }

    public void HealPlayer(){
        currentHealth++;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        UICorntroller.instance.UpdateHealthDisplay();
    }
}
