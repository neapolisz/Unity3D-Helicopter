using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_Base_RBController : MonoBehaviour
{
    #region Variables
    protected Rigidbody rb;
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
            HandlePhysics();
        }
    }
    #endregion

    #region Custom Methods
    protected virtual void HandlePhysics()
    {

    }
    #endregion
}
