using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider HealthBar;
    public float health;
    public float MaxHealth;// 1000
    public Image slider1Fill;
    public GameObject lowBattery;
    public Slider slider1; //connected the slider

    void Start()
    {
        health = MaxHealth;
        HealthBar = GetComponent<Slider>();
        lowBattery = GetComponent<GameObject>();
        HealthBar.maxValue = MaxHealth;
        HealthBar.value = health;

    }

    void Update()
    {
        health -= 0.05f;
        HealthBar.value = health;
        if (health < 30)
        {
            slider1Fill.color = Color.Lerp(Color.red, Color.green, slider1.value / 100);
        }
    }
}
