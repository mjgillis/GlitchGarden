using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    public enum Status { SUCCESS, FAILURE };

    private Text starText;
    private int starTotal = 100;

    // Use this for initialization
    private void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void AddStars(int amount) {
        starTotal += amount;
        UpdateDisplay();
    }

    public Status UseStars (int amount) {
        if (starTotal >= amount) {
            starTotal -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }

    private void UpdateDisplay() {
        starText.text = starTotal.ToString();
    }

}
