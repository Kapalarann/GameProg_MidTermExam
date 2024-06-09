using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI eggUI, chickUI, henUI, roosterUI;
    private GameObject[] eggs, chicks, hens, roosters;

    void Start()
    {

    }

    void Update()
    {
        eggs = GameObject.FindGameObjectsWithTag("egg");
        eggUI.text = "Eggs: " + eggs.Length.ToString();
        chicks = GameObject.FindGameObjectsWithTag("chick");
        chickUI.text = "Chicks: " + chicks.Length.ToString();
        hens = GameObject.FindGameObjectsWithTag("hen");
        henUI.text = "Hens: " + hens.Length.ToString();
        roosters = GameObject.FindGameObjectsWithTag("rooster");
        roosterUI.text = "Roosters: " + roosters.Length.ToString();
    }
}
