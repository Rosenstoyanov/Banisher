using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

class Viper : MonoBehaviour
{
    private int live = 3;
    //one healt falling straight down
    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(0, -KillEnemyHolder.viperSpeed);
    }

    void OnMouseDown()
    {
        if (KillEnemyHolder.gameOver)
        {
            SceneManager.LoadScene(0);
        }
        live--;
        if(live <= 0)
        {
            KillEnemyHolder.viper--;
            Destroy(gameObject);
        }
    }
}

