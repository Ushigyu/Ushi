using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    bool score1 = true;

    // Update is called once per frame
    void Update()
    {
        if (clearscene1.score == 2 && score1 == true)
        {
            transform.position = new Vector3(1.0f, 1.0f, 1.0f);
            score1 = false;
        }
    }
}
