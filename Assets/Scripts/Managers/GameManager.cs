using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    //Update is called every frame.
    void Update()
    {

    }

    void OnApplicationQuit()
    {
        
    }

    public void LoadGame()
    {

    }

    public void SaveGame()
    {

    }

    private void StartGame()
    {

    }

    
}
