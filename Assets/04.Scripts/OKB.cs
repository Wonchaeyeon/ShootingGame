
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OKB : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Title"); //너가 넘기고 싶은 씬
    }
}
