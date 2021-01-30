using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque2 : MonoBehaviour
{
    #region Variables
    private Rigidbody rb;
    public float torqueSpeed = 3;
    #endregion

    #region Built-in Methods
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb)
        {
            rb.AddTorque(Vector3.up * torqueSpeed);
        }
    }
    #endregion
}
