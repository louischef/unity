using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PorteManuel3 : MonoBehaviour
{
    [SerializeField] Animator Porte;
    [SerializeField] private Text Infos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Infos.gameObject.SetActive(true);
    }

    void OnTriggerExit()
    {
        Infos.gameObject.SetActive(false);
    }

    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
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
