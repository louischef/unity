﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bouton2 : MonoBehaviour
{
    public static bool activer = false;

    [SerializeField] Text Infos;

    public static GameObject bouton;
    // Start is called before the first frame update
    void Start()
    {
        bouton = GetComponent<GameObject>();

        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!activer)
            Infos.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Infos.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
        {
            activer = true;
            Infos.gameObject.SetActive(false);
        }
    }

    public static bool Ratio()
    {
        return activer = false;
    }
}
