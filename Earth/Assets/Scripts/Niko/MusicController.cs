using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public GameObject musicController;

    private void Start()
    {
        Object.DontDestroyOnLoad(musicController);
    }
}
