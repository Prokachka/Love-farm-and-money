using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float _speed; //Скорость перемещения камеры
    [SerializeField] private float _zoomSpeed; //Скорость приближения/отдаления
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position +=  new Vector3(Input.GetAxis("Horizontal"), 0,0) * _speed *Time.deltaTime;
        transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * _speed * Time.deltaTime;
        transform.position += new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel")) * _zoomSpeed;
    }
}
