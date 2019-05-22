
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WayGame : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Way"); //너가 넘기고 싶은 씬
    }
}
