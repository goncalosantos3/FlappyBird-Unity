using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{   
    public LogicScript logic;
    public BirdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision){ // O pássaro passou pelo meio dos pipes
        // O objeto que colidiu com o meio dos pipes estava na camada do pássaro, ou seja, era o pássaro
        if(collision.gameObject.layer == 3 && bird.birdIsAlive){
            logic.addScore(1);
        }
    }
}
