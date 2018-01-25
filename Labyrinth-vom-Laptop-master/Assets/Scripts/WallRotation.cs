using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotation : MonoBehaviour {
    private int turnx = 5;
    public int collisionCount;
    public float x;

	void Start () {
        collisionCount = 0;
    }

    void Update()
    {
        if (collisionCount == 0)
        {
            x = x - 1 * Time.deltaTime;
        }

        if(x <= 0)
        {
            int turnx = Random.Range(0, 10);
            if (turnx == 2)
            {
                transform.Rotate(0, 90, 0);
            }
            else if (turnx == 1)
            {
                transform.Rotate(0, -90, 0);
            }
            else if (turnx == 4)
            {
                transform.Rotate(0, 180, 0);
            }
            x = 5;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }


    public void OnCollisionExit(Collision collision)
    {
        collisionCount--;
    }
}
