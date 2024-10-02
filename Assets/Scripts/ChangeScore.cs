using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{
    int score;

    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 4;
        scoreText.SetText($"Žc‚è‚¨•ó {score}");
        clearscene1.score = score;
    }
    public void Addscore()
    {
        --score;
        scoreText.SetText($"Žc‚è‚¨•ó {score}");
        clearscene1.score = score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
