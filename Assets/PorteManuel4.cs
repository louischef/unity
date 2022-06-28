using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PorteManuel4 : MonoBehaviour
{
    [SerializeField] Animator Porte;
    [SerializeField] private Text Infos;
    [SerializeField] private Text Carte;
    [SerializeField] private Text Autre;

    // Start is called before the first frame update
    void Start()
    {
        Infos.gameObject.SetActive(false);
        Carte.gameObject.SetActive(false);
        Autre.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        if (!(Get_Card.leBool))
            Carte.gameObject.SetActive(true);
        else
            Infos.gameObject.SetActive(true);
    }

    void OnTriggerExit()
    {
        Infos.gameObject.SetActive(false);
        Carte.gameObject.SetActive(false);
    }

    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active && Get_Card.leBool)
        {
            Porte.Play("door_3_open");
            StartCoroutine("StopDoor");
        }
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }
}
