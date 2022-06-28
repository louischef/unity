using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteEnVerre : MonoBehaviour
{
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
        Porte.Play("glass_door_open");
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
