using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static int health;
    public static int mana;

    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();

        health = 10;
        mana = 10;
    }

    private void Update()
    {
        text.text = "Health: " + health + "\nMana: " + mana;
    }
}
