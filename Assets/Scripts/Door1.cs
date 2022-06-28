using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator Porte;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        /*if (Porte.GetCurrentAnimatorStateInfo(0).IsName("door_3_closed") || Porte.GetCurrentAnimatorStateInfo(0).IsName("door_3_open"))
            Porte.Play("door_3_open");
        else
            Porte.Play("door_3_opened");*/
        Porte.Play("door_3_open");
        StartCoroutine("StopDoor");
    }

    private void OnTriggerExit(Collider other)
    {
        Porte.enabled = true;
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }
}
