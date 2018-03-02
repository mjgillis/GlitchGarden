using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager) {
            float volume = PlayerPrefsManager.getMasterVolume();
            musicManager.ChangeVolume(volume);
        } else {
            Debug.Log("Couldn't find musicmanager");
        }
	}
	
}
