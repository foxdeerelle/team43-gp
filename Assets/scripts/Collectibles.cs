using UnityEngine;
using UnityEngine.Audio;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private int pointsToAdd;
    [SerializeField] private AudioSource audioPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerController>())
        {
            PointsManager.Instance.IncreasePoints(pointsToAdd);
            audioPlayer.Play();
            Destroy(gameObject);
        }
    }

}


