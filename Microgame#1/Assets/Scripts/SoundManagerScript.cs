using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip winSound, loseSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        winSound = Resources.Load<AudioClip> ("win");
        loseSound = Resources.Load<AudioClip> ("lose");
        
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playsound (string clip)
    {
         switch (clip)
        {
            case "win":
                audioSrc.PlayOneShot(winSound);
                break;
            case "lose":
                audioSrc.PlayOneShot(loseSound);
                break;
        }
    }
}
