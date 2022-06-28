using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class felicitation : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        
      Cursor.lockState = CursorLockMode.None;
    }
    public void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    // Update is called once per frame
   }
