using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Screwdriver_Get : MonoBehaviour
{
    [SerializeField] private Text Get_Screwdriver;
    [SerializeField] private GameObject Screwdriver;
    [SerializeField] private Text Need_This;

    // Start is called before the first frame update
    void Start()
    {
        Need_This.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Get_Screwdriver.gameObject.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Get_Screwdriver.gameObject.SetActive(false);
            Need_This.gameObject.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Need_This.gameObject.SetActive(false);
        Screwdriver.SetActive(false);
    }
    
}
