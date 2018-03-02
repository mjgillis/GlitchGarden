using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;

    private AudioSource music;

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += this.OnLoadCallback;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= this.OnLoadCallback;
    }

    void OnLoadCallback(Scene scene, LoadSceneMode sceneMode)
    {
        int sceneNumber = scene.buildIndex;
        Debug.Log("SceneNumber " + sceneNumber);
        Debug.Log("SceneMode " + sceneMode);
        AudioClip thisLevelMusic = levelMusicChangeArray[sceneNumber];

        if (thisLevelMusic)
        {
            music.clip = thisLevelMusic;
            music.loop = true;
            music.Play();

            Debug.Log("Music Clip" + thisLevelMusic);
        }
    }

    public void ChangeVolume (float volume){
        music.volume = volume;
    }

}
