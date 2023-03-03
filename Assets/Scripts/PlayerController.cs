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
     public GameObject gameoverPanel;
     public GameObject gameclearPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameoverPanel.SetActive(false);
        gameclearPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 186){
            gameclearPanel.SetActive(true);
        }

        if(transform.position.y < -2){
            gameoverPanel.SetActive(true);
            
        }
        if (gameoverPanel.activeSelf)
        {
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (gameclearPanel.activeSelf)
        {
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(0);
            }
            else if(Input.GetKeyDown("e"))
            {
                Application.Quit ();
            }
        }

        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);    }
}
