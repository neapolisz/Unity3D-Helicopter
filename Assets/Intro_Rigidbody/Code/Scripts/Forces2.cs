using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces2 : IP_Base_RBController
{
    #region Variables
    public float maxSpeed = 1f;
    #endregion

    #region Built-in Methods
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(new Vector3(1f, 0f, 0f) * maxSpeed);
        }
    }
    #endregion
}
