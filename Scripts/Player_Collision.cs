using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public player_Movement movement;

    void OnCollisionEnter(Collision collision_info)
    {
        if(collision_info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
