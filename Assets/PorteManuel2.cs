using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PorteManuel2 : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Text Infos;
    [SerializeField] private GameObject Keypad;
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        //keypad = GameObject.FindGameObjectWithTag("keypad");
        Keypad.SetActive(false);
        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
            Affiche();

        if (Keypad.active && Ans.text != "Correct")
        {
            Cursor.lockState = CursorLockMode.None;
            cam1.SetActive(false);
            cam2.SetActive(false);
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            cam1.SetActive(true);
            cam2.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Ans.text != "Correct")
            Infos.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Infos.gameObject.SetActive(false);
        Keypad.SetActive(false);
    }

    void Affiche()
    {
        Keypad.SetActive(true);
    }
}
