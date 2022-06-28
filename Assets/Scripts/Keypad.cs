using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    [SerializeField] private Text infos;
    
    
    public AudioClip NombreSound;
    private AudioSource audioSourceNombre;
    
    public AudioClip ValidationSound;
    private AudioSource audioSourceValidation;
    


    private string Answer = "2003";

    private void Start()
    {
        
        
        audioSourceNombre = GetComponent<AudioSource>(); 
        audioSourceNombre.clip = NombreSound;
        audioSourceNombre.playOnAwake = false;
        
        
        
    }

    private void Update()
    {

    }

    public void Number(int number)
    {
        if (Ans.text == "Invalid")
            Ans.text = "";
        audioSourceNombre.Play();
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
        audioSourceValidation = GetComponent<AudioSource>();
        audioSourceValidation.clip = ValidationSound;
        audioSourceValidation.playOnAwake = false;
        audioSourceValidation.Play();
      
        yield return new WaitForSeconds(0.5f);
        Door.enabled = false;
        
    }
}
