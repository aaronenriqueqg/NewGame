using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
        //shows game over
        
        // Reset the game when a collision occurs
      
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
            logic.showGameOverText();
            
        }
        

    }


}
