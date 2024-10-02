using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Player")]
    private GameObject target;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = gameObject.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
}
