using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{           
    public Transform playerPosition;
    public Rigidbody playerRB;
    //public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerRB.transform.position.x , playerRB.transform.position.y+3f, playerRB.transform.position.z-8f);
    }
}
