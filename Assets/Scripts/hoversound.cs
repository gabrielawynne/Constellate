using UnityEngine;

public class hoversound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonClickSound;
    public AudioClip buttonHoverSound;

    public void playButtonClick()
    {
        audioSource.PlayOneShot(buttonClickSound, .5f);
    }
    public void playButtonHover()
    {
        audioSource.PlayOneShot(buttonHoverSound, .5f);
    }

}
