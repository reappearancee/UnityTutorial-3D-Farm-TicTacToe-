using UnityEngine;

public class AudioService : MonoBehaviour, IAudioService
{
    public void PlaySound()
    {
        Debug.Log("Play sound");
    }

    public void StopSound()
    {
        Debug.Log("Stop sound");
    }
}
