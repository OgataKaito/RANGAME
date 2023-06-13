using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 push = new Vector3(0, 0, 0);
        push = Vector3.forward;
        push = Camera.main.transform.TransformDirection(push);
        push.y = 0;
        if (push != Vector3.zero) transform.forward = push;
        push = push.normalized * _speed;
        rb.velocity = push;
    }
}
