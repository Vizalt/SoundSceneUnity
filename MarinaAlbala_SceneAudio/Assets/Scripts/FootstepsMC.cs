using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsMC : MonoBehaviour
{
    public AudioClip[] FootstepsGrass;
    public AudioClip[] FootstepsMetal;
    public AudioClip[] FootstepsSand;
    public AudioClip[] FootstepsWater;
    public AudioClip[] FootstepsStone;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f, 1.0f);
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        switch (material)
        {
            case "Grass":
                if (FootstepsGrass.Length > 0)
                    audioSource.PlayOneShot(FootstepsGrass[Random.Range(0, FootstepsGrass.Length)]);
                break;

            case "Metal":
                if (FootstepsMetal.Length > 0)
                    audioSource.PlayOneShot(FootstepsMetal[Random.Range(0, FootstepsMetal.Length)]);
                break;

            case "Sand":
                if (FootstepsSand.Length > 0)
                    audioSource.PlayOneShot(FootstepsSand[Random.Range(0, FootstepsSand.Length)]);
                break;

            case "Water":
                if (FootstepsSand.Length > 0)
                    audioSource.PlayOneShot(FootstepsWater[Random.Range(0, FootstepsWater.Length)]);
                break;
            case "Stone":
            if (FootstepsSand.Length > 0)
                 audioSource.PlayOneShot(FootstepsStone[Random.Range(0, FootstepsStone.Length)]);
            break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
            case "Metal":
                material = collision.gameObject.tag;
                break;
            case "Water":
                material = collision.gameObject.tag;
                break;
            case "Sand":
                material = collision.gameObject.tag;
                break;
            case "Stone":
                material = collision.gameObject.tag;
                break;
            default:
                break;
        }
    }
}

