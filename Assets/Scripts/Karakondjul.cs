using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Karakondjul : MonoBehaviour {
    //2live falling down

    //body.velocity = new Vector2(-2, -2);
    private int live = 2;
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
        body.velocity = new Vector2(0, -KillEnemyHolder.karakSpeed);
    }

    void OnMouseDown()
    {
        if (KillEnemyHolder.gameOver)
        {
            SceneManager.LoadScene(0);
        }
        live--;
        if (live == 0)
        {
            KillEnemyHolder.karakondjul--;
            Destroy(gameObject);
        }
    }
}
