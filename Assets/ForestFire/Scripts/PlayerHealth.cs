using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public TMP_Text HealthText;
    public Slider HealthBar;
    public int MaxHealth = 15;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar.maxValue = MaxHealth;
        health = MaxHealth;
        HealthText.text = "Player: " + health.ToString();
        HealthBar.value = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceHealth()
    {
        health = health - 2;
        //Debug.Log(health.ToString());
        //HealthBar.GetComponent<TextMeshPro>().text = health.ToString();
        HealthText.text = "Player: " + health.ToString();
        HealthBar.value = health;
        if (health < 0)
        { 
            Debug.Log("You've been burnt");
        }
    }
}
