using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthText : MonoBehaviour
{

    Text healthText;

    void Start()
    {
        //healthText.text = "xxx";
        healthText = GetComponent<Text>();
    }

    public void DecreaseHealthLaser()
    {
        string text = healthText.text;
        text = text.Remove(text.Length - 1);
        healthText.text = text;
    }

    public void DecreaseHealthEnemyShip()
    {
        healthText.text = "health :";
    }

    public void ResetHealth()
    {
        Destroy(gameObject);
    }
}
