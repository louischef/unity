using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fin : MonoBehaviour
{
    [SerializeField] private Text Final_Cut;
    // Start is called before the first frame update
    void Start()
    {
        Final_Cut.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Final_Cut.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Final_Cut.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Fin", LoadSceneMode.Single);
        }
    }
}
