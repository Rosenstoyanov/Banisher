using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GhostSpawner : MonoBehaviour {
    //x- ot -2 do 2
    //y- ot 4 do -6
    public GameObject karakondjul;
    public GameObject brodnik;
    public GameObject talasum;
    public GameObject viper;
    public GameObject kravesmurt;
    private Random random;

    public float maxTime = 4;
    public float minTime = 3.5f;

    private float time;

    //The time to spawn the object
    private float spawnTime;

    // Use this for initialization
    void Start () {
        time = minTime;
        SetRandomTime();
        KillEnemyHolder.initKills(10, 10, 10, 10, 10);
    }

    void FixedUpdate()
    {
        if (KillEnemyHolder.karakondjul <= 0 
            && KillEnemyHolder.talasum <= 0 
            && KillEnemyHolder.brodnik <= 0
            && KillEnemyHolder.viper <= 0
            && KillEnemyHolder.kravesmurt <= 0)
        {
            Time.timeScale = 0;
        }
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnCreature();
            time = minTime;
            SetRandomTime();
        }
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void SpawnCreature()
    {
        float rand = Random.Range(0.0f, 5.0f);
        switch ((int)rand)
        {
            case 0:
                SpawnKarakondjul();
                break;

            case 1:
                SpawnBrodnik();
                break;

            case 2:
                SpawndTalasum();
                break;
            case 3:
                SpawnViper();
                break;
            case 4:
                SpawnKrav();
                break;
        }
        //if (random.NextInt(100) < 40)
        //{
        //    // will be true 40% of the time
        //}
    }

    private void SpawnKrav()
    {
        GameObject krav = (GameObject)Instantiate(kravesmurt, new Vector3(generateX(), 4.5F, -5), Quaternion.identity);
    }

    private void SpawnViper()
    {
        GameObject vip = (GameObject)Instantiate(viper, new Vector3(generateX(), 4.5F, -5), Quaternion.identity);
    }

    private void SpawnKarakondjul()
    {
        GameObject karank = (GameObject)Instantiate(karakondjul, new Vector3(generateX(), 4.5F, -5), Quaternion.identity);
    }

    private void SpawndTalasum()
    {
        GameObject talas = (GameObject)Instantiate(talasum, new Vector3(generateX(), 4.5F, -5), Quaternion.identity);
    }

    private void SpawnBrodnik()
    {
        GameObject brod = (GameObject)Instantiate(brodnik, new Vector3(generateX(), 4.5F, -5), Quaternion.identity);
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void OnMouseDown()
    {
        if (KillEnemyHolder.gameOver)
        {
            SceneManager.LoadScene(0);
        }
    }

    private float generateX()
    {
        return Random.Range(-2.0F, 2.0F);
    }


    public void onClikc()
    {

    }
}
