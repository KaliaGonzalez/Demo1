using UnityEngine;

public class PlayAudioOnEvent : MonoBehaviour
{
    [Tooltip("AudioSource que se va a reproducir")]
    public AudioSource audioSource;

    [Tooltip("Si se ignora el audio source y se reproduce un AudioClip espec�fico")]
    public AudioClip clipOverride;

    [Tooltip("Si se debe reproducir el clipOverride en vez del AudioSource")]
    public bool useClipOverride = false;

    public void PlaySound()
    {
        if (useClipOverride && clipOverride != null)
        {
            AudioSource.PlayClipAtPoint(clipOverride, transform.position);
        }
        else if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("PlayAudioOnEvent: No se encontr� AudioSource ni ClipOverride asignado.");
        }
    }
}
