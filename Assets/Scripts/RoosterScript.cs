using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterScript : MonoBehaviour
{
    public float deathTimer;
    public Transform pos;

    void Start()
    {
        pos.eulerAngles = new Vector3(pos.eulerAngles.x, 90, pos.eulerAngles.z);
        //layTimer = 30.0f; 
        //deathTimer = 40.0f;
    }

    void Update()
    {
        deathTimer -= Time.deltaTime;

        if (deathTimer <= 0.0f)
        {
            deathTimer = 10.0f;
            Dies();
        }
    }
    void Dies()
    {
        Object.Destroy(this.gameObject);
    }
}
