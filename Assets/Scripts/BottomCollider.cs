using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BottomCollider : MonoBehaviour {
    private int couner;
    public Image houses;
    private SpriteRenderer sp;
    public Sprite oneDMG;
    public Sprite twoDmg;
    public Sprite threeDmg;
    public Sprite fourDmg;
    public Sprite fiveDmg;
    public Sprite sixDmg;
    public GameObject gameOverImg;
    private bool gameOverFlag = false;

	// Use this for initialization
	void Start () {
        //houses = GameObject.FindWithTag("houses");
        //sp = houses.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        couner++;
        damageHouse();
        Destroy(other.gameObject);
    }

    private void damageHouse()
    {
        switch (couner)
        {
            case 1:
                houses.sprite = oneDMG;
                break;

            case 2:
                houses.sprite = twoDmg;
                break;

            case 3:
                houses.sprite = threeDmg;
                break;

            case 4:
                houses.sprite = fourDmg;
                break;

            case 5:
                houses.sprite = fiveDmg;
                break;

            case 6:
                houses.sprite = sixDmg;
                Time.timeScale = 0;
                gameOverImg.SetActive(true);
                KillEnemyHolder.gameOver = true;
                //gameOverFlag = true;
                break;
        }
    }
}
