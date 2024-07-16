using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenLogicScript : MonoBehaviour
{
    public void goToMainScene()
    {
        // SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(1).name);
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
}
