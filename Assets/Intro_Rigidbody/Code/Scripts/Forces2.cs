using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces2 : MonoBehaviour
{
    #region Variables
    public float maxSpeed = 1f;

    private Rigidbody rb;
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
            rb.AddForce(new Vector3(1f, 0f, 0f) * maxSpeed);
        }
    }
    #endregion
}
