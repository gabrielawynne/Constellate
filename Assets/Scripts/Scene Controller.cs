using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void quitGame() {
        Debug.Log("Game Quit");
        Application.Quit();
    }

    public void changeScenes(string sceneName) {
        Debug.Log("Scene Changed");
        SceneManager.LoadScene(sceneName);
    }
}
