using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemVie : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;
    public string levelToLoad;
    public AudioClip Sound;
	private AudioSource audioSourceCri;
    bool coroutineCalled;
    
    void Start()
    {
        life = hearts.Length;
        audioSourceCri = GetComponent<AudioSource>();
		audioSourceCri.clip = Sound; 
		audioSourceCri.playOnAwake = false;
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1);
        }
        if (dead == true)
        {
            // StartCoroutine(WaitForSwitchScene());
            
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if(life <= 0)
            {
                dead = true;
                audioSourceCri.Play();
                StartCoroutine(WaitForSwitchScene(2.0f));                
                SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
            }
        } 

    }
    IEnumerator WaitForSwitchScene(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
    }
}
