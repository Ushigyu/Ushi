using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    [SerializeField]
    private string SceneName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (clearscene1.score == 0)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
