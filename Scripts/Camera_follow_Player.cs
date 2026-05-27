using UnityEngine;

public class Camera_follow_Player : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(11.148f, 0f, 0f);
    }
}