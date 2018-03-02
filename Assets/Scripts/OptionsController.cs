using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindGameObjectWithTag("MusicTag").GetComponent<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.getMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}

    public void SaveAndExit () {
        PlayerPrefsManager.setMasterVolume(volumeSlider.value);
        PlayerPrefsManager.setDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01A Start Menu");
    }

    public void SetDefaults () {
        volumeSlider.value = .8f;
        difficultySlider.value = 2f;
    }
}
