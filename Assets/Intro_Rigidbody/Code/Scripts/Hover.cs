using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    #region Variables
    [Header("Hover Properties")]
    public float hoverHeight = 3f;
    public Transform hoverPosition;
    public float test = 0;

    private Rigidbody rb;
    private float weight;
    private float currentGroundDistance;
    #endregion

    #region Built-in Methods
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            weight = rb.mass * Physics.gravity.magnitude;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb)
        {
            CalculateGroundDistance();
            float groundDifference = hoverHeight - currentGroundDistance;
            Vector3 finalHoverForce = Vector3.up * (1 + groundDifference);
            rb.AddForce(finalHoverForce * weight);
        }
    }
    #endregion

    #region Custom Methods
    void CalculateGroundDistance()
    {
        Ray hoverRay = new Ray(hoverPosition.position, Vector3.down);
        Debug.DrawRay(hoverPosition.position, hoverRay.direction, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(hoverRay, out hit, 100f))
        {
            if (hit.transform.tag == "ground")
            {
                currentGroundDistance = hit.distance;
            } else
            {
                test = 2;
            }
        }
    }
    #endregion
}
