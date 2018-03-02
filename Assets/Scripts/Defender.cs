using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    // Being used to get component for attack collisions

    public int starCost = 100;
    private StarDisplay starDisplay;

    // Use this for initialization
    void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    //This method is tied to the animation of the star creation and passes in the int 10 for value of a star
    public void AddStars(int amount)
    {
        //This calls the starDisplay script method and passes the 10 int from animation variable
        starDisplay.AddStars(amount);
    }
}
