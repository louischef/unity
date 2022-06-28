using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MDP : MonoBehaviour
{
    [SerializeField] GameObject livre;
    [SerializeField] Text mdp;
    [SerializeField] Text Infos;
    [SerializeField] GameObject keypad;
    [SerializeField] GameObject fond;
    void Start()
    {
        mdp.gameObject.SetActive(false);
        fond.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Infos.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        mdp.gameObject.SetActive(false);
        fond.SetActive(false);
        Infos.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
        {
            keypad.SetActive(false);
            Infos.gameObject.SetActive(false);
            mdp.gameObject.SetActive(true);
            fond.SetActive(true);
        }
    }
}
