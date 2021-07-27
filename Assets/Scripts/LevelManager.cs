using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public float waitToRespond;
    public int gemCollected;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespondPlayer(){
        StartCoroutine(RespownCo());
    }

    private IEnumerator RespownCo(){
        PlayerController.instance.gameObject.SetActive(false);
        yield return new WaitForSeconds(waitToRespond);
        PlayerController.instance.gameObject.SetActive(true);
        PlayerController.instance.transform.position = CheckpontController.instance.spawnPoint;
        PlayerHealthController.instance.currentHealth = PlayerHealthController.instance.maxHealth;
        UICorntroller.instance.UpdateHealthDisplay();
    }
}
