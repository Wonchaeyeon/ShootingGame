using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Play"); //너가 넘기고 싶은 씬
    }
}