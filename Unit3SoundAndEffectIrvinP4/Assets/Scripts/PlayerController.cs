using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
    private RigidBody playerRb;
{
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<RigidBody>();
        playerRb.AddForce(Vecotr3.up * 1000)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}