using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void clickHelp()
    {
        SceneManager.LoadScene(3);
    }

    public void click()
    {
        SceneManager.LoadScene(1);
        //Application.LoadLevel(1);
    }
}
