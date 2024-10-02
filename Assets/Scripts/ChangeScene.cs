using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    private string SceneName;
    public void OnButton()
    {
        SceneManager.LoadScene(SceneName);
    }
}
