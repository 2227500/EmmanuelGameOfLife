using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private float timer;
    //public GameObject HealthBar;

    private void Awake()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

        // Update is called once per frame
        void Update()
    {
        //if (playerHealth != null)
        //{
        //    timer += Time.deltaTime;
        //    if(timer > 1)
        //    {
        //        timer = 0;
        //        playerHealth.ReduceHealth();
        //    }
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Debug.Log("In the file");
            playerHealth.ReduceHealth();
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    playerHealth = null;
    //}
}
