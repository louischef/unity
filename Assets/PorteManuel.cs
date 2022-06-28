using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PorteManuel : MonoBehaviour
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
            Porte.Play("door_2_open");
            StartCoroutine("StopDoor");
            if (!(Porte.enabled))
                SceneManager.LoadScene("Scene4", LoadSceneMode.Single);
        }
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }
}
