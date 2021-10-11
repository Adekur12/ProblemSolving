using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
        playerRb.velocity = new Vector2(2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
