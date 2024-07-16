using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength = 13;
    public LogicScript logic;
    private bool isBirdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            birdRigidBody.velocity = new Vector2(0, flapStrength);
        }

        // Check if the bird is out of bounds
        if(transform.position.y > 20 || transform.position.y < -20)
        {
            logic.gameOver();
            isBirdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
    }

    public bool isBirdAlivef()
    {
        return isBirdAlive;
    }
}
