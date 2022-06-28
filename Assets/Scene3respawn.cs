using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3respawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject respawnPoint;
    Vector3 pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
    }
}
