using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpontController : MonoBehaviour
{
    public static CheckpontController instance;
    private Checkpoint[] checkpoints;
    public Vector3 spawnPoint;
    // Start is called before the first frame update

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        checkpoints = FindObjectsOfType<Checkpoint>();

        spawnPoint = PlayerController.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactevateCheckpoints(){
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckPoints();
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint){
        spawnPoint = newSpawnPoint;
    }
}
