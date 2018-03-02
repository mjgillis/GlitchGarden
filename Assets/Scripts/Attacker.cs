using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {
    
    [Tooltip ("Average number of seconds between appearances")]
    public float seenEverySeconds;

    private float currentSpeed;
    private GameObject currentTarget;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);

        if (!currentTarget) {
            anim.SetBool("isAttacking", false);
        }
	}

    // Called from animator to control speed between animation stages
    public void setSpeed(float speed) {
        currentSpeed = speed;
    }

    // Called from the animator at specific time of blow on attack
    public void strikeCurrentTarget (float damage) {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health){
                health.DealDamage(damage);
            }
        }

    }

    // Called from collision of Attacker & Object
    public void Attack (GameObject obj){
        currentTarget = obj;
    }

}
