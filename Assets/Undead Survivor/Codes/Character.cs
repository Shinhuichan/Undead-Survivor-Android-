using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public static float Speed {
        get { return GameManager.instance.playerId == 0 ? 1.15f : 1f; }
    }
    public static float WeaponSpeed {
        get { return GameManager.instance.playerId == 1 ? 1.09f : 1f; }
    }
    public static float WeaponRate {
        get { return GameManager.instance.playerId == 1 ? 0.91f : 1f; }
    }
    public static float Damage {
        get { return GameManager.instance.playerId == 2 ? 1.13f : 1f; }
    }
    public static int Count {
        get { return GameManager.instance.playerId == 3 ? 1: 0; }
    }
    public static int Health {
        get { return GameManager.instance.playerId == 4 ? 125 : 100; }
    }
}
