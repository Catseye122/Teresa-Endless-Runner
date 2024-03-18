using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    [SerializeField] private float leftBound = -12f;
    [SerializeField] private float rightBound = 10f;
    // Update is called once per frame
    private void Update()
    {
        if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        if(transform.position.x > rightBound)
        {
            Destroy(gameObject);

        }


    }
}
