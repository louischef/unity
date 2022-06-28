using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pORT : MonoBehaviour
{
    [SerializeField] Text Carte;

    // Start is called before the first frame update
    void Start()
    {
        Carte.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Carte.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Carte.gameObject.SetActive(false);
    }
}
