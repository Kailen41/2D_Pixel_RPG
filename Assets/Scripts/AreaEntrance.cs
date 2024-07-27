using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;

    void Start()
    {
        if (transitionName == PlayerController.instance.areaTransitionNamePC)
        {
            PlayerController.instance.transform.position = transform.position;
        }
    }

    void Update()
    {
        
    }
}
