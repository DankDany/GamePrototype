using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.right;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.left;

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.back;
    }
}
