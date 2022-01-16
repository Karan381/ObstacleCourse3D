using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float x = 0;
    [SerializeField] float y = 0;
    [SerializeField] float z = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
