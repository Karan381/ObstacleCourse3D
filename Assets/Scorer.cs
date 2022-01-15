using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("Score:" + score);
        
    }
}
