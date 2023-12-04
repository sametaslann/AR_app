using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WalkTheWolf : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 50 * Time.deltaTime * transform.forward;
        if (transform.position.z > 100)
        {
            transform.position.Set(transform.position.x, transform.position.y, -100);
        }
    }
}
