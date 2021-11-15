using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check for low horizontal position
        if (transform.position.y < -10){
            // Disable Whisper audio to prevent overlap with next scene
            Destroy(GameObject.Find("WhisperSource"));

            // reset mazeNumber at game over
            LevelGenerator.levelNumber = 0;
            
            SceneManager.LoadScene("GameOver");
        }
    }
}
