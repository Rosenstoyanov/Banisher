using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

class Kravesmurt : MonoBehaviour
{
    private int live = 3;
    private Rigidbody2D body;
    private int x = 1;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(x, -KillEnemyHolder.kravSpeed);
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
            KillEnemyHolder.kravesmurt--;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "leftCollid")
            x = 1;

        if (coll.gameObject.tag == "rightCollid")
            x = -1;
    }

}

