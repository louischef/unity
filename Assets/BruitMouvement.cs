using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruitMouvement : MonoBehaviour
{
    public AudioClip metalSound, curSound;
    public float volmin, volmax, pitchmin, pitchmax;
    AudioSource audioS;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    private void OnCollisionStay(Collision col)
    {
        switch (col.gameObject.tag)
        {
            case "SolMetal":
                curSound = metalSound;
                break;


        }
    }
    private void OnCollisionExit(Collision col)
    {
        curSound = null;
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!audioS.isPlaying)
            {
                audioS.volume = Random.Range(volmin, volmax);
                audioS.pitch = Random.Range(pitchmin, pitchmax);

                /*if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
                {
                    audioS.pitch = Random.Range(pitchmin/2, pitchmax/2);
                }
                */
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    audioS.pitch = (float)1.2;
                }
                audioS.PlayOneShot(curSound);
            }
        }
    }
}
