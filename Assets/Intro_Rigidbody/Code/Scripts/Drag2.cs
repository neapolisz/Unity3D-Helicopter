using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2 : MonoBehaviour
{
    // Start is called before the first frame update
    #region Variables
    [Header("Drag Properties")]
    public float dragFactor = 0.05f;

    private Rigidbody rb;
    #endregion

    #region Built-in Methods
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb)
        {
            float currentSpeed = rb.velocity.magnitude;
            float finalDrag = currentSpeed * dragFactor;
            rb.drag = finalDrag;
        }
    }
    #endregion
}
