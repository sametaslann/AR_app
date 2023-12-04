using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WalkTheWolf : MonoBehaviour
{

    void Update()
    {
        transform.position += 100 * Time.deltaTime * transform.forward;
        
    }
}
