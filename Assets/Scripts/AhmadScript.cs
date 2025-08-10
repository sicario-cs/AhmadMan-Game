using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AhmadScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool ahmadIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ahmadIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            logic.GameOver();
            ahmadIsAlive = false;
    }
   
}
