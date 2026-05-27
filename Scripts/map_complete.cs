using UnityEngine;
using UnityEngine.SceneManagement;

public class map_complete : MonoBehaviour
{
    public void LoadNextMap()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
