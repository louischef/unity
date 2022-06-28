using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class porteTransition : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator Porte;
    [SerializeField] private Text Infos;
    [SerializeField] private GameObject Screwdriver;
    [SerializeField] private Text Need_Sd;

    private bool have_It;
    void Start()
    {
        Infos.gameObject.SetActive(false);
        Need_Sd.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Screwdriver.active))
        {
            Need_Sd.gameObject.SetActive(true);
        }
        if (!(Screwdriver.active))
        {
            var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
            Infos.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
            {
                Porte.Play("door_2_open");
                StartCoroutine("StopDoor");
                if (!(Porte.enabled))
                    SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Porte.enabled = true;
        Infos.gameObject.SetActive(false);
        Need_Sd.gameObject.SetActive(false);
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }

}
