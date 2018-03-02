using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLane : MonoBehaviour {

    public GameObject[] attackerPrefabArray;
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject thisAttacker in attackerPrefabArray) {
            if (isTimetoSpawn (thisAttacker)) {
                Spawner(thisAttacker);
            }   
        }
	}

    void Spawner (GameObject myGameObject) {
        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }

    bool isTimetoSpawn (GameObject attackerGameObject) {

        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;

        if (Time.deltaTime > meanSpawnDelay) {
            Debug.LogWarning("Spawn rate capped by frame rate");
        }

        float threshHold = spawnsPerSecond * Time.deltaTime / 5;

        return (Random.value < threshHold );
    }
}
