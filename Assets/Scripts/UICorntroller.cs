using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICorntroller : MonoBehaviour
{
    // Start is called before the first frame update
    public static UICorntroller instance;
    public Image har1, hart2, hart3;
    public Sprite hartFull, hartDead, halfHart;
    public Text jamText;

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        UpdateGameJamCaount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay(){
        switch (PlayerHealthController.instance.currentHealth)
        {
            case 6:
                har1.sprite = hartFull;
                hart2.sprite = hartFull;
                hart3.sprite = hartFull;

                break;
            case 5:
                har1.sprite = hartFull;
                hart2.sprite = hartFull;
                hart3.sprite = halfHart;

                break;
            case 4:
                har1.sprite = hartFull;
                hart2.sprite = hartFull;
                hart3.sprite = hartDead;

                break;
            case 3:
                har1.sprite = hartFull;
                hart2.sprite = halfHart;
                hart3.sprite = hartDead;

                break;
            case 2:
                har1.sprite = hartFull;
                hart2.sprite = hartDead;
                hart3.sprite = hartDead;

                break;
            case 1:
                har1.sprite = halfHart;
                hart2.sprite = hartDead;
                hart3.sprite = hartDead;

                break;
            case 0:
                har1.sprite = hartDead;
                hart2.sprite = hartDead;
                hart3.sprite = hartDead;

                break; 

        }
    }
    
    public void UpdateGameJamCaount(){
        jamText.text = LevelManager.instance.gemCollected.ToString();
    }

}
