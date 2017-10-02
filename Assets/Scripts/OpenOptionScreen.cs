using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenOptionScreen : MonoBehaviour {
    private int curr = 1;
    private int maxScreen = 5;
    public GameObject first;
    public GameObject second;
    public GameObject thirt;
    public GameObject fourth;
    public GameObject fifth;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("adasd");
        switch (curr)
        {
            case (1):
                first.SetActive(false);
                second.SetActive(true);
                break;
            case (2):
                second.SetActive(false);
                thirt.SetActive(true);
                break;
            case (3):
                thirt.SetActive(false);
                fourth.SetActive(true);
                break;
            case (4):
                fourth.SetActive(false);
                fifth.SetActive(true);
                break;
            case (5):
                first.SetActive(false);
                first.SetActive(true);
                break;
            case (6):
                SceneManager.LoadScene(0);
                break;
        }
        curr++;
    }
}
