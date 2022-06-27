using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PorteManuel2 : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Text Infos;

    private GameObject keypad;

    // Start is called before the first frame update
    void Start()
    {
        keypad = GameObject.FindGameObjectWithTag("keypad");
        keypad.SetActive(false);
        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
            Affiche();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Ans.text != "Correct")
            Infos.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Infos.gameObject.SetActive(false);
        keypad.SetActive(false);
    }

    void Affiche()
    {
        keypad.SetActive(true);
    }
}
