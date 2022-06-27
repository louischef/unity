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
    private Scene scene;
    void Start()
    {
        Infos.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Porte.Play("door_2_open");
        StartCoroutine("StopDoor");
        Infos.gameObject.SetActive(true);
    }


    private void OnTriggerStay(Collider other)
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
        if (Input.GetKeyDown(KeyCode.E) && Infos.gameObject.active)
        {
            scene = SceneManager.LoadScene("Scene2", parameters);
            Infos.gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Porte.enabled = true;
        Infos.gameObject.SetActive(false);
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }

}
