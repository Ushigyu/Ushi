using UnityEngine;

public class MoveWall : MonoBehaviour
{
    float moveValue = 35.0f;

    Vector3 MovePosition;

    // Start is called before the first frame update
    void Start()
    {
        MovePosition = new(0.04f, -2.222f, moveValue);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, MovePosition, Time.deltaTime);

        if (transform.position.z == 35.0f)
        {
            transform.position = new Vector3(0.04f, -2.222f, 60.0f);
        }
        
    }
}
