using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Locate_Card : MonoBehaviour
{
    [SerializeField] private Text Where_Card;
    [SerializeField] private Text Player_Lol;
    [SerializeField] private Text Infos;

    // Start is called before the first frame update
    void Start()
    {
        Where_Card.gameObject.SetActive(false);
        Player_Lol.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Where_Card.gameObject.SetActive(true);
        Infos.gameObject.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Where_Card.gameObject.SetActive(false);
            Infos.gameObject.SetActive(false);
            Player_Lol.gameObject.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Player_Lol.gameObject.SetActive(false);
    }

}
