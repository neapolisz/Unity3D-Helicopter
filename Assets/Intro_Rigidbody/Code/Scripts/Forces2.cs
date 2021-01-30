using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces2 : IP_Base_RBController
{
    #region Variables
    public float maxSpeed = 1f;
    #endregion

    #region Custom Methods
    // Update is called once per frame
    protected override void HandlePhysics()
    {
        rb.AddForce(new Vector3(1f, 0f, 0f) * maxSpeed);
    }
    #endregion
}
