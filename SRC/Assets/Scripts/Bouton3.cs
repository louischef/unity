using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Bouton3 : MonoBehaviour
{
    public static bool activer = false;

    [SerializeField] Text Infos;

    public static GameObject bouton;
    Renderer couleur;
    // Start is called before the first frame update
    void Start()
    {
        Infos.gameObject.SetActive(false);

        bouton = GetComponent<GameObject>();
        couleur = bouton.GetComponent<Renderer>();

        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (activer)
            couleur.material.color = Color.red;
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
