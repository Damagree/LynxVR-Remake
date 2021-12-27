using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadSceneByName(string name) => SceneManager.LoadScene(name);
    public void Quit() => Application.Quit();
}
