using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int scene = 1;
    public void OpenScene()
        {
            SceneManager.LoadScene(scene);
        }
}
