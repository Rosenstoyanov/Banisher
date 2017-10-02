using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Item1Click : MonoBehaviour {
    public int screen = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if(screen == 2)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
}
