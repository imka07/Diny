using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneFunction : MonoBehaviour
{
    public void ChangeSceneByAddingIndex(int indexToAdd)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + indexToAdd);
    }
   
}
