using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemVie : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;
    
    void Start()
    {
        life = hearts.Length;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1);
        }
        if (dead == true)
        {
            Debug.Log("Emy est morte");
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if(life < 1)
            {
                dead = true;
            }
        } 

    }
}
