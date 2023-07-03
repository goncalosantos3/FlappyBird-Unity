using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource flap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){ // Carregou no espaço
            myRigidbody.velocity = Vector2.up * flapStrength;
            flap.Play();
        }

        if(transform.position.y > 17 || transform.position.y < -17){
            logic.gameOver(); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
       logic.gameOver(); 
       birdIsAlive = false;
    }
}
