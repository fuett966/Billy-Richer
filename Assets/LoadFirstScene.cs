using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstScene : MonoBehaviour
{
    public string nextLevelName;
      
    public void LoadGame(){
        SceneManager.LoadScene(nextLevelName);
    }
}
