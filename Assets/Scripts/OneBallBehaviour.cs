using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    static int ballCount = 0;
    public float XSpeed;
    public float YSpeed;
    public float ZSpeed;
    public float Multiplier = 0.75F;
    public int BallNumber;
    public int TooFar = 5;


    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
        ballCount++;
        BallNumber = ballCount;
    }

    // Update is called once per frame
    void Update()
    {
        XSpeed += Multiplier - Random.value * Multiplier * 2;
        YSpeed += Multiplier - Random.value * Multiplier * 2;
        ZSpeed += Multiplier - Random.value * Multiplier * 2;
        transform.Translate(Time.deltaTime * XSpeed, Time.deltaTime * YSpeed, Time.deltaTime * ZSpeed);

        if ((Mathf.Abs(transform.position.x) > TooFar) || (Mathf.Abs(transform.position.y) > TooFar) || (Mathf.Abs(transform.position.z) > TooFar))
        {
            ResetBall();
        }
    }

    void OnMouseDown()
    {
        GameController controller = Camera.main.GetComponent<GameController>();

        if (!controller.GameOver)
        {
            controller.ClickOnBall();
            Destroy(gameObject);
        }
    }


    public void ResetBall()
    {
        XSpeed = Multiplier - Random.value * Multiplier * 2;
        YSpeed = Multiplier - Random.value * Multiplier * 2;
        ZSpeed = Multiplier - Random.value * Multiplier * 2;
        transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
    }
}
