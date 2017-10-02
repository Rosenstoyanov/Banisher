using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class KillEnemyHolder
{
    public static int karakondjul = 0;
    public static int talasum = 0;
    public static int brodnik = 0;
    public static int viper = 0;
    public static int kravesmurt = 0;
    public static List<GameObject> ghostsList;

    public static int kravSpeed = 1;
    public static int viperSpeed = 1;
    public static int talasSpeed = 1;
    public static int karakSpeed = 1;
    public static int brodSpeed = 1;

    public static bool gameOver = false;

    public static void setSpeed(int krav, int vip, int talas, int karak, int brod)
    {
        kravSpeed = krav;
        viperSpeed = vip;
        talasSpeed = talas;
        karakSpeed = karak;
        brodSpeed = brod;
    }

    public static void initKills(int karak, int talas, int brod, int vip, int krav)
    {
        ghostsList = new List<GameObject>();
        karakondjul = karak;
        talasum = talas;
        brodnik = brod;
        viper = vip;
        kravesmurt = krav;
    }
}
