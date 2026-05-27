using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    private float startPosition;

    void Start()
    {
        startPosition = player.position.z;
    }

    void Update()
    {
        float score = player.position.z - startPosition;
        scoreText.text = Mathf.Round(score).ToString();
    }
}