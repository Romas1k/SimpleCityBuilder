using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;          //GameManager prefab to instantiate.
    public GameObject guiManager;           //GUIManager prefab to instantiate.
    public GameObject levelManager;         //LevelManager prefab to instantiate.
    public GameObject soundManager;         //SoundManager prefab to instantiate.


    void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);

        if (SoundManager.instance == null)
            Instantiate(soundManager);

        if (GameManager.instance == null)
            Instantiate(guiManager);

        if (SoundManager.instance == null)
            Instantiate(levelManager);
    }
}
