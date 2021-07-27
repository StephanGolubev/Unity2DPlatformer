using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    public Transform trans;
    public Transform  farBackground, middleBackground;

    public float minHight, maxHight;
    private float lastXPos;

    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(trans.position.x, trans.position.y, transform.position.z);

        float climmedY = Mathf.Clamp(transform.position.y, minHight, maxHight);
        transform.position = new Vector3(transform.position.x, climmedY, transform.position.z);

        float ammountToMoveX = transform.position.x - lastXPos;

        farBackground.position = transform.position + new Vector3(ammountToMoveX, 0f,0f);
        middleBackground.position += new Vector3(ammountToMoveX*.5f, 0f, 0f);

        lastXPos = transform.position.x;
    }
}
