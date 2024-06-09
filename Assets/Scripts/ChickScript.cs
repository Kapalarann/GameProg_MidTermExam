using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickScript : MonoBehaviour
{
    public float growTimer;
    public GameObject hen, rooster;
    private GameObject[] henCounter;
    public Transform pos;

    void Start()
    {
        pos.eulerAngles = new Vector3(pos.eulerAngles.x, 90, pos.eulerAngles.z);
        //growTimer = 10.0f;
    }

    void Update()
    {
        growTimer -= Time.deltaTime;

        if (growTimer <= 0.0f)
        {
            growTimer = 10.0f;
            timerEnded();
        }
    }

    void timerEnded()
    {
        henCounter = GameObject.FindGameObjectsWithTag("hen");
        if (henCounter.Length == 0)
        {
            Instantiate(hen, pos.position, pos.rotation);
        }
        else
        {
            int rand = Random.Range(0, 2);
            if (rand==1) 
            {
                Instantiate(rooster, pos.position, pos.rotation);
            }
            else
            {
                Instantiate(hen, pos.position, pos.rotation);
            }
        }

        Object.Destroy(this.gameObject);
    }
}
