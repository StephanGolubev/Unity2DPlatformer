using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegePlayer : MonoBehaviour
{
    public static DamegePlayer instance;

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

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player")
        {
            PlayerJumpAfterDamage.instance.JumpDamageNow();
            PlayerHealthController.instance.DealDamege();
        }
    }
}
