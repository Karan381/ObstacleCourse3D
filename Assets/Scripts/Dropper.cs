using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody obsbody;
    [SerializeField] float timetoWait = 5f;// Start is called before the first frame update

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        obsbody = GetComponent<Rigidbody>();
        obsbody.useGravity = false;
    }
    private void Update()
    {
       
        if (Time.time > timetoWait)
        {
            renderer.enabled = true;
            obsbody.useGravity = true;
        }

        
    }
}
