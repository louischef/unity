using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boutons : MonoBehaviour
{
    [SerializeField] Animator Porte;

    public int compteur = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bouton1.activer)
        {
            compteur++;
            Bouton1.Ratio();
        }
        if (Bouton2.activer)
        {
            compteur++;
            Bouton2.Ratio();
        }
        if (Bouton3.activer)
        {
            compteur++;
            Bouton3.Ratio();
        }
        if (compteur == 3)
        {
            Porte.Play("door_3_open");
            StartCoroutine("StopDoor");
        }
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Porte.enabled = false;
    }
}
