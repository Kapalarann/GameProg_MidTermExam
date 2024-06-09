using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public float hatchTimer;
    public GameObject chick;
    public Transform pos;

    void Update()
    {
        hatchTimer -= Time.deltaTime;

        if (hatchTimer <= 0.0f)
        {
            hatchTimer = 10.0f;
            timerEnded();
        }
    }

    void timerEnded()
    {
        Instantiate(chick, pos.position, pos.rotation);
        Object.Destroy(this.gameObject);
    }

}
