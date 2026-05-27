using UnityEngine;

public class End_Trigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}