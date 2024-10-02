using UnityEngine;

public class ThereAndBack7 : MonoBehaviour
{
    float moveValue = -2.2f;

    Vector3 TurnbackPosition;

    // Start is called before the first frame update
    void Start()
    {
        TurnbackPosition = new(moveValue, -3.4f, 25.0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);

        if (transform.position.x == -2.2f)
        {
            moveValue = 2.3f;
            TurnbackPosition = new(moveValue, -3.4f, 25.0f);
            transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);
        }
        if (transform.position.x == 2.3f)
        {
            moveValue = -2.2f;
            TurnbackPosition = new(moveValue, -3.4f, 25.0f);
            transform.position = Vector3.MoveTowards(transform.position, TurnbackPosition, Time.deltaTime);

        }
    }
}
