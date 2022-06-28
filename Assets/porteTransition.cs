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
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    void Start()
    {
        Infos.gameObject.SetActive(false);
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
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
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
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
