using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public float levelSeconds = 100;

    private Slider slider;
    private AudioSource audiosource;
    private bool isEndofLevel = false;
    private LevelManager levelManager;
    private GameObject winLabel;

	// Use this for initialization
	void Start ()
    {
        slider = GetComponent<Slider>();
        audiosource = GetComponent<AudioSource>();
        levelManager = FindObjectOfType<LevelManager>();
        FindYouWin();
        winLabel.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        slider.value = Time.timeSinceLevelLoad / levelSeconds;

        if (Time.timeSinceLevelLoad >= levelSeconds && !isEndofLevel) {
            audiosource.Play();
            winLabel.SetActive(true);
            Invoke("LoadNextLevel", audiosource.clip.length); 
            isEndofLevel = true;
        }
	}

    private void FindYouWin()
    {
        winLabel = GameObject.Find("You Win");

        if (!winLabel)
        {
            Debug.LogWarning("Please create you win message object");
        }
    }

    void LoadNextLevel(){
        levelManager.LoadNextLevel();
    }
}
