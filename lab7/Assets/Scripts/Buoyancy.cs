using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0f)
        {
            float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
            rigidBody.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
