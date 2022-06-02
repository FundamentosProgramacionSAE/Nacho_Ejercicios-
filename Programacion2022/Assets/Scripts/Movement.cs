using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 10f;
    private Rigidbody _rigidbody;
    private Vector3 _movementDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        _rigidbody.MovePosition((_rigidbody.position + _movementDirection.normalized)*velocity*Time.fixedDeltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        _movementDirection.x = Input.GetAxis("Horizontal");
        _movementDirection.z = Input.GetAxis("Vertical");
    }
}
