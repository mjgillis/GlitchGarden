using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, gun;

    private GameObject projectileParent;
    private Animator animator;
    private SpawnerLane myLaneSpawner;

    private void Start()
    {
        animator = GetComponent<Animator>(); 

        //Creates a parent if necessary for projectiles
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent) {
            projectileParent = new GameObject("Projectiles");
        }

        SetMyLaneSpawner();
    }

    private void Update()
    {
        //Switches animation bool for attacking vs. not attacking to fire projectiles
        if(IsAttackerAheadInLane()) {
            animator.SetBool("isAttacking", true);
        } else {
            animator.SetBool("isAttacking", false);
        }
    }

    //Fires projectile
    private void Fire(){
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
	
    //Look through all spawns and set variable for lane if found
    void SetMyLaneSpawner () {
        SpawnerLane[] spawnerLaneArray = GameObject.FindObjectsOfType<SpawnerLane>();

        //Returns the y position of each spawner lane
        foreach (SpawnerLane spawnerLane in spawnerLaneArray) {
            if (spawnerLane.transform.position.y == transform.position.y) {
                myLaneSpawner = spawnerLane;
                return;
            }
        }

        Debug.LogError(name + " can't find spawner in lane");
    }

    //Checks to see if attacker is ahead to shoot projectiles
    bool IsAttackerAheadInLane () {

        //Exit if no attacker in lane
        if (myLaneSpawner.transform.childCount <= 0 ) {
            return false;
        }

        //If attacker is ahead in lane, go into attack mode
        foreach (Transform attacker in myLaneSpawner.transform) {
            if (attacker.transform.position.x > transform.position.x) {
                return true;
            }
        }

        //Else just return false
        return false;
    }
}
