using UnityEngine;
using UnityEngine.SceneManagement;

public class audiomanager : MonoBehaviour
{
    [Header("------Audio Manager-----")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------Audio Clip------")]
    [SerializeField] AudioClip loadingscreen;
    [SerializeField] AudioClip backgroundsong;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "start_page")
        {
            MusicSource.clip = loadingscreen;
        }
        else
        {
            MusicSource.clip = backgroundsong;
        }

        MusicSource.Play();
    }
}