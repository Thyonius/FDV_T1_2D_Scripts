using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaModifier : MonoBehaviour
{
    public int manaValue = 10;
    public float timeToRegen = 5.0f;
    public Material usedBoxMat;
    public Material unusedBoxMat;

    GameObject player;
    bool isEnabled = true;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        isEnabled = true;
        gameObject.GetComponent<Renderer>().material = unusedBoxMat;
    }

    private void Update()
    {
        if (!isEnabled)
        {
            timeToRegen -= Time.deltaTime;

            if (timeToRegen <= 0)
            {
                manageState();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            manageState();
        }
    }

    private void manageState ()
    {
        if (isEnabled)
        {
            StatsManager.mana += 5;
            gameObject.GetComponent<MeshRenderer>().material = usedBoxMat;
            isEnabled = false;
            timeToRegen = 5.0f;

            return;
        }

        gameObject.GetComponent<MeshRenderer>().material = unusedBoxMat;
        isEnabled = true;
    }
}
