using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oui : MonoBehaviour
{
    Animation baleine;

    IEnumerator Anim()
    {
        baleine.Play("dive");

        yield return new WaitForSeconds(baleine["Action"].length);

 
    }
    // Start is called before the first frame update
    void Start()
    {
        baleine = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        /*if (baleine.isPlaying)
        {

        }
            
        else
        {
            baleine.transform.Rotate(new Vector3(0, 180, 0), Space.Self);
            baleine.Play("dive2");
        }*/


    }
}
