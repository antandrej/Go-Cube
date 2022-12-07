using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCheck : MonoBehaviour
{

    public PlayerMovement aliveCheck;

    void Update()
    {
        if (this.transform.position.y < -1)
            aliveCheck.alive = false;
    }
}
