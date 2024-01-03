using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true) 
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset the game when a collision occurs
        if (collision.gameObject.layer == 6)
        {
            ResetGame();
        }
        
    }

    void ResetGame()
    {
        // Add code to reset your game here
        // For example, you can reload the scene or reset player position
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// transform.position = initialPosition;
    }
}
