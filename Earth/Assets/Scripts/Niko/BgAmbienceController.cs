using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgAmbienceController : MonoBehaviour
{
    private AudioSource ambience;

    private void Awake()
    {
        ambience = GetComponent<AudioSource>();
    }

    private void Start()
    {
        StartCoroutine(Ambience());
    }

    IEnumerator Ambience()
    {
        ambience.Play();
        yield return new WaitForSeconds(30);
        ambience.Play();
        StartCoroutine(Ambience());
    }
}
