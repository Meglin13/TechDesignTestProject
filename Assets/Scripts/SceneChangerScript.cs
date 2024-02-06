using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    public void ChangeScene(int id)
    {
        if (id < SceneManager.sceneCount || id >= 0)
        {
            SceneManager.LoadScene(id, LoadSceneMode.Single); 
        }
        else if (id < 0)
        {
            SceneManager.LoadScene(SceneManager.sceneCount - 1, LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    public void ChangeScene(string name) => SceneManager.LoadScene(name);

    public void NextScene() => ChangeScene(SceneManager.GetActiveScene().buildIndex + 1);

    public void PreviousScene() => ChangeScene(SceneManager.GetActiveScene().buildIndex - 1);
}
