using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToMainScene()
    {
        SceneManager.LoadScene("Level");
    }
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToLeadScene()
    {
        SceneManager.LoadScene("Lead");
    }
}
