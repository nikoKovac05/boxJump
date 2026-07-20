using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject player;
    public float cameraOffset;
    public bool isTimeAttack = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTimeAttack)
        {
            gameObject.transform.position = new Vector3(0, player.transform.position.y + cameraOffset, -10);
        }
        else
        {
            gameObject.transform.position = new Vector3(-13, player.transform.position.y + cameraOffset, -10);
        }
    }
}
