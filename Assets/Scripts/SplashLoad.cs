using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashLoad : MonoBehaviour {

        public float autoLoadNextLevelAfter;

        private void Start()
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }

        public void LoadNextLevel()
        {
            SceneManager.LoadScene("01A Start Menu");
        }
}
