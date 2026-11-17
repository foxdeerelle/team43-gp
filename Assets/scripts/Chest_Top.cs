using System.Collections;
using UnityEngine;

public class Chest_Top : MonoBehaviour
{

    private Animator Chest_Anim_Manager;
    private bool isOpen = false;
    public GameObject UI_Win;
    [SerializeField] private AudioSource winAudioPlayer;
    [SerializeField] private AudioSource openAudioPlayer;

    void Awake()
    {
        Chest_Anim_Manager = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            isOpen = true;
            Chest_Anim_Manager.SetTrigger("Open");
            openAudioPlayer.Play();
            UI_Win.SetActive(true);
            winAudioPlayer.Play();
        }
    }

}
