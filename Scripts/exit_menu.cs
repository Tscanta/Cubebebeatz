using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_menu : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Map-01");
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}