using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScenes : MonoBehaviour
{

     Scene currentScene;
     int sceneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
          currentScene = SceneManager.GetActiveScene();
          sceneIndex = currentScene.buildIndex;
    }

     public void loadNextScene()
     {
          SceneManager.LoadScene(sceneIndex + 1);
     }

     public void loadPreviousScene()
     {
          if (sceneIndex > 0)
               SceneManager.LoadScene(sceneIndex - 1);
          else SceneManager.LoadScene(0);

     }
}
