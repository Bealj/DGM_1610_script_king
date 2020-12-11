using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds = 30f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds){
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
        
    }
}
