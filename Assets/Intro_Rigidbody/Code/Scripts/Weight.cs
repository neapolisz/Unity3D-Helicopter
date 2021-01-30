using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    #region Variables
    [Header("Weight Properties")]
    public float weightInLbs = 10f;

    public float weight;

    const float lbs2Kg = 0.454f;
    const float kg2Lbs = 2.205f;

    private Rigidbody rb;
    #endregion

    #region Built-in Methods
    // Start is called before the first frame update
    void Start()
    {
        float finalWeight = weightInLbs * lbs2Kg;
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.mass = finalWeight;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
