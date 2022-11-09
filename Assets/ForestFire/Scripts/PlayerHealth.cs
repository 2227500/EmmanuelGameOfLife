using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceHealth()
    {
        health = health - 2;
        Debug.Log(health.ToString());
        if(health < 0)
        {
            Debug.Log("You've been burnt");
        }
    }
}
