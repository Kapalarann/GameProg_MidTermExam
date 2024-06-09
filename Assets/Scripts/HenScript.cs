using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float layTimer, deathTimer;
    public GameObject egg;
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
        layTimer -= Time.deltaTime;

        if (layTimer <= 0.0f)
        {
            layTimer = 10.0f;
            layEggs();
        }

        if (deathTimer <= 0.0f)
        {
            deathTimer = 10.0f;
            Dies();
        }
    }

    void layEggs()
    {
        pos.position += new Vector3(0, 1.0f, 0);
        for (int i = 0; i < Random.Range(2, 10); i++)
        {
            Instantiate(egg, pos.position, pos.rotation);
        }
    }

    void Dies()
    {
        Object.Destroy(this.gameObject);
    }
}
