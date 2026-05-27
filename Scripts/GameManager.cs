using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool game_has_ended = false;

    public float restart_Delay = 1f;

    public GameObject completeMapUI;

    public void CompleteLevel()
    {
        completeMapUI.SetActive(true);
    }

    public void EndGame()
    {
        if (game_has_ended == false)
        {
            game_has_ended = true;
            Debug.Log("Game Over!");
            Invoke(nameof(Restart), restart_Delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}