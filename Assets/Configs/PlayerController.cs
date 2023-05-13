using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDir;

    [SerializeField]
    private float movePower;

    [SerializeField]
    private float moveSpeed; 

    [SerializeField]
    private float jumpPower;

    [SerializeField]
    private float rotateSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        //Rotate();
        // LookAt();
    }

    private void Move()
    {
        rb.AddForce(moveDir * movePower, ForceMode.Force); // ������� ���⿡ ���� �Ʊ�
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self); // �ڱ� �������� ȸ��
        transform.position += moveDir * Time.deltaTime; // x : 1/s �� �����Ӵ� �ɸ��� �ð��� ���� ������� �ӷ����� ������ �� ����
        // transform.Translate(moveDir * moveSpeed *  Time.deltaTime); // �ٶ󺸴� �������� ȸ��
        // transform.Translate(moveDir * moveSpeed *  Time.deltaTime , Space.World); // ����������� ȸ��
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }

    public void LookAt() // �������� �������ָ� �ٷ� ��
    {
        // transform.LookAt(new Vector3(0, 0, 0));
    }
    public void Rotation()
    {
        transform.position = new Vector3(0, 0, 0);
        // transform.rotation = new Quaternion.Euler(0, 0, 0);
        // Vector3 rotation = transform.rotation.eulerAngles();
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse); // ������� ���⿡ ���� �Ʊ�
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x; // ���� ������
        moveDir.z = value.Get<Vector2>().y; // �� �Ʒ�
        Debug.Log(moveDir);
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }

}
