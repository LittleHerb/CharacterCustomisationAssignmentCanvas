using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public void SceneTransition()
    {
        SceneManager.LoadScene("Game");
    }
}
