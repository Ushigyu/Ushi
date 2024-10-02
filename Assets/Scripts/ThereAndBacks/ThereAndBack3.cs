using UnityEngine;

public class ThereAndBack3 : MonoBehaviour
{
    float moveValue = -0.34f;

    Vector3 TurnbackPosition;

    // Start is called before the first frame update
    void Start()
    {
        TurnbackPosition = new(0.05f, moveValue, 20.0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);

        if (transform.position.y == -0.34f)
        {
            moveValue = -3.8f;
            TurnbackPosition = new(0.05f, moveValue, 20.0f);
            transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);
        }
        if (transform.position.y == -3.8f)
        {
            moveValue = -0.34f;
            TurnbackPosition = new(0.05f, moveValue, 20.0f);
            transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);

        }
    }
}
