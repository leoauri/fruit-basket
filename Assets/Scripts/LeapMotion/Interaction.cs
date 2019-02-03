using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

[RequireComponent(typeof(LeapServiceProvider))]
public class Interaction : MonoBehaviour
{
    private LeapServiceProvider provider;
    // Start is called before the first frame update
    void Start()
    {
        provider = GetComponent<LeapServiceProvider>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
