using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.AI;
//using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
   // private Rigidbody rb;
   // private Vector3 moveDir;
   //
   // [SerializeField]
   // private float movePower;
   //
   // [SerializeField]
   // private float moveSpeed; 
   //
   // [SerializeField]
   // private float jumpPower;
   //
   // [SerializeField]
   // private float rotateSpeed;
   //
   // private void Awake()
   // {
   //     rb = GetComponent<Rigidbody>();
   // }
   // private void Update()
   // {
   //     Move();
   //     //Rotate();
   //     // LookAt();
   // }
   //
   // private void Move()
   // {
   //     rb.AddForce(moveDir * movePower, ForceMode.Force); // 가고싶은 방향에 무게 싣기
   //     transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self); // 자기 기준으로 회전
   //     transform.position += moveDir * Time.deltaTime; // x : 1/s 한 프레임당 걸리는 시간에 대해 곱해줘야 속력으로 움직일 수 있음
   //     // transform.Translate(moveDir * moveSpeed *  Time.deltaTime); // 바라보는 방향으로 회전
   //     // transform.Translate(moveDir * moveSpeed *  Time.deltaTime , Space.World); // 월드기준으로 회전
   // }
   // private void Rotate()
   // {
   //     transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
   // }
   //
   // public void LookAt() // 목적지를 지정해주면 바로 감
   // {
   //     // transform.LookAt(new Vector3(0, 0, 0));
   // }
   // public void Rotation()
   // {
   //     transform.position = new Vector3(0, 0, 0);
   //     // transform.rotation = new Quaternion.Euler(0, 0, 0);
   //     // Vector3 rotation = transform.rotation.eulerAngles();
   // }
   // private void Jump()
   // {
   //     rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse); // 가고싶은 방향에 무게 싣기
   // }
   //
   // private void OnMove(InputValue value)
   // {
   //     moveDir.x = value.Get<Vector2>().x; // 왼쪽 오른쪽
   //     moveDir.z = value.Get<Vector2>().y; // 위 아래
   //     Debug.Log(moveDir);
   // }
   // private void OnJump(InputValue value)
   // {
   //     Jump();
   // }

}
