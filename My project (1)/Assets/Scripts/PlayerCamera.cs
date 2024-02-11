using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private float _mouseSensitivity = 3.0f;
    private float _rotationY;
    private float _rotationX;

    [SerializeField]
    private Transform _target;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _rotationY += mouseX;
        _rotationX += mouseY;

        _rotationX = Mathf.Clamp(_rotationX, -40, 40);

        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    
        transform.position = _target.position - transform.forward;

    }
}