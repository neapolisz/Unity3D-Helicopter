using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    #region Variables
    [Header("Hover Properties")]
    public float hoverHeight = 3f;
    public Transform hoverPosition;
    public float rotForce = 2;
    public float timeCounter = 0;

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
            HandleHoverForce();
            //RotationForce();
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
            }
        }
    }

    void HandleHoverForce()
    {
        float groundDifference = hoverHeight - currentGroundDistance;
        Vector3 finalHoverForce = Vector3.up * (1 + groundDifference);
        rb.AddForce(finalHoverForce * weight);
    }

    void RotationForce()
    {
        timeCounter += Time.deltaTime;
        rb.AddForce(Vector3.forward * Mathf.Cos(timeCounter));
        rb.AddForce(Vector3.right * Mathf.Sin(timeCounter));
    }
    #endregion
}
