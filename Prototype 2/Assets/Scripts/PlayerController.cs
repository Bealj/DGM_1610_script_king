using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10f;
    // Start is called before the first frame update

    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // keeps player in bounds on left side
        if(transform.position.x < -xRange)
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        {

        }
         // keeps player in bounds on right side
        if(transform.position.x > xRange)
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        {

        }
        // moves player from right to left
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
