using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private Animator anim;
    public float cooldownTime = 2f;
    private float nextFireTime = 0f;
    public static int noOfClicks = 0;
    float lastClickedTime = 0;
    float maxComboDelay = 1;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

   // Check for mouse input
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("hit1", true);
        }
        else
            anim.SetBool("hit1", false);
    }
}