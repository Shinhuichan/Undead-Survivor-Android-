using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoint;
    public SpawnData[] spawnData;
    public float levelTime;
    int level;

    float timer;

    void Awake() {
        spawnPoint = GetComponentsInChildren<Transform>();
        // 최대 게임 시간 / 몬스터의 종류 
        levelTime = GameManager.instance.maxGameTimeI / spawnData.Length;
    }
    void Update() {
        if (!GameManager.instance.isLive)
            return;

        timer += Time.deltaTime;
        level = Mathf.Min (Mathf.FloorToInt(GameManager.instance.gameTimeI / levelTime), spawnData.Length -1);

        if (timer > spawnData[level].spawnTime) {            
            timer = 0;
            Spawn();
        }
    }
    void Spawn() {
        GameObject enemy =  GameManager.instance.pool.Get(0);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(spawnData[level]);
    }

}
[System.Serializable]
public class SpawnData {
    public float spawnTime;
    public int spriteType;    
    public int health;
    public float speed;
}
