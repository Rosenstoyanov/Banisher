using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Brodnik : MonoBehaviour {
    //one healt falling straight down
    private Rigidbody2D body;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        body.velocity = new Vector2(0, -KillEnemyHolder.brodSpeed);
    }

    void OnMouseDown()
    {
        KillEnemyHolder.brodnik--;
        Destroy(gameObject);
        if (KillEnemyHolder.gameOver)
        {
            SceneManager.LoadScene(0);
        }
    }
}
