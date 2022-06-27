using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    [SerializeField] private Text infos;
    public AudioClip DoorSound;
    private AudioSource audioSource;


    private string Answer = "2003";

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); //identify the AudioSource component.
        audioSource.clip = DoorSound;
        audioSource.playOnAwake = false; //Disable the "Play on awake" parameterer because we don't want to play the screamer sound when starting the game.
    }

    private void Update()
    {

    }

    public void Number(int number)
    {
        if (Ans.text == "Invalid")
            Ans.text = "";
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            Door.Play("door_2_open");
            
            StartCoroutine("StopDoor");
        }
        else
        {
            Ans.text = "Invalid";
        }
    }

    IEnumerator StopDoor()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.5f);
        Door.enabled = false;
        
    }
}
