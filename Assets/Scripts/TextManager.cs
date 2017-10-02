using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
    public Text karakondjul;
    public Text talas;
    public Text brodnik;
    public Text viper;
    public Text krav;

    public void setText()
    {
        karakondjul.text = KillEnemyHolder.karakondjul < 0 ? "0" : KillEnemyHolder.karakondjul.ToString();
        talas.text = KillEnemyHolder.talasum < 0 ? "0" : KillEnemyHolder.talasum.ToString();
        brodnik.text = KillEnemyHolder.brodnik < 0 ? "0" : KillEnemyHolder.brodnik.ToString();
        viper.text = KillEnemyHolder.viper < 0 ? "0" : KillEnemyHolder.viper.ToString();
        krav.text = KillEnemyHolder.kravesmurt < 0 ? "0" : KillEnemyHolder.kravesmurt.ToString();
    }

    // Use this for initialization
    void Start () {
	
	}

    void FixedUpdate()
    {
        setText();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
