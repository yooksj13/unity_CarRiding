using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
     float turnSpeed = 45.0f;
     float horizontalInput;
     float forwardInput;
     float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 185){
            Application.Quit ();
        }

        if(transform.position.y < -2){
            SceneManager.LoadScene (0);
            
        }

        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);    }
}
