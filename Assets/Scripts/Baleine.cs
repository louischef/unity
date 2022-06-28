using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Baleine : MonoBehaviour
{
    [SerializeField] ThirdPersonCharacter baleine;
    [SerializeField] GameObject waypoint;
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
        baleine.Move(waypoint.transform.position, false, false);
    }
}
