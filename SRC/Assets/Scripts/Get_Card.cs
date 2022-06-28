using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Get_Card : MonoBehaviour
{
    [SerializeField] private Text Finally;
    [SerializeField] private GameObject Chip;
    [SerializeField] private Text Infos;

    public static bool leBool = false;

    // Start is called before the first frame update
    void Start()
    {
        Finally.gameObject.SetActive(false);
        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Finally.gameObject.SetActive(false);
        Infos.gameObject.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
        {
            Finally.gameObject.SetActive(true);
            Infos.gameObject.SetActive(false);
            leBool = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Finally.gameObject.SetActive(false);
        Destroy(Chip);
    }

}
