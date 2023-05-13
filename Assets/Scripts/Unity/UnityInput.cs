using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class UnityInput : MonoBehaviour
{
    /************************************************************************
	 * ����Ƽ �Է�
	 * 
	 * ����Ƽ���� ������� ����� ������ �� �ִ� ����
	 * ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� ����
	 * ����Ƽ�� �پ��� Ÿ���� �Է±��(Ű���� �� ���콺, ���̽�ƽ, ��ġ��ũ�� ��)�� ����
	 ************************************************************************/
    private void Update()
    {
        InputByDevice();
        InputByInputManager();
        InputByInputSystem();
    }

    // <Device>
    // Ư���� ��ġ�� �������� �Է� ����
    // Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
    // ����� �е� �� �������� �����ġ���� �ִ� �ô뿡 �� ����� �׷��� ���� ����� �ƴ�
    private void InputByDevice()
    {
        // Ű���� �Է�
        if (Input.GetKeyUp(KeyCode.Space))        // Up : Ű�� ���� ����
            Debug.Log("Key Up");
        if (Input.GetKeyDown(KeyCode.Space))      // Down : ������ ����
            Debug.Log("Key Down");
        if (Input.GetKey(KeyCode.Space))          // ������ �ִ� ��
            Debug.Log("Kwy pressing");

        // ���콺�� �Է°���
        // ���ʹ�ư 0, �����ʹ�ư 1, ���(��)��ư 2
        if (Input.GetMouseButton(0))
            Debug.Log("Mouse Left button pressing");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("Mouse Left button Up");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Mouse Left button Down");
    }

    // <InputManager>
    // ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
    // �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
    // ����Ƽ �������� Edit -> Project Settings -> Input Manager ���� ����

    // ��, ����Ƽ ��â���� ����̱� ������ Ű����, ���콺, ���̽�ƽ�� ���� ��ġ���� �����
    // �߰�) VR Oculus Integraion Kit ���� ��� �Է¸Ŵ����� ������ ����� ���
    // �츰 vr���̶� �Է¸Ŵ������� �ٸ��� ����� vr��⿡ ���� �Է��� ���� ������
    private void InputByInputManager()
    {
        // ��ư �Է�
        // Fire1 : Ű����(Left Ctrl), ���콺(Left Button), ���̽�ƽ(button0)���� ���ǵ�
        if (Input.GetButton("Fire1"))
            Debug.Log("Fire1 is pressing");
        if (Input.GetButtonDown("Fire1"))
            Debug.Log("Fire1 is down");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("Fire1 is up");

        // �� �Է�
        // �������ϸ� ���尪�̶��ؼ� ���׸Ӵ� ������
        // Horizontal(����) : Ű����(a,d / ��, ��), ���̽�ƽ(���� �Ƴ��α׽�ƽ �¿�)
        float x = Input.GetAxis("Horizontal");
        // Vertical(����) : Ű����(w,s / ��, ��), ���̽�ƽ(���� �Ƴ��α׽�ƽ ����)
        float y = Input.GetAxis("Vertical");

        Debug.Log($"{x} , {y}");
    }



    // <InputSystem>
    // Unity 2019.1 ���� �����ϰ� �� �Է¹��
    // ������Ʈ�� ���� �Է��� ��������� Ȯ��
    // GamePad, JoyStick, Mouse, Keyboard, Pointer, Pen, TouchScreen, XR ��� ���� ����
    private void InputByInputSystem()
    {
        // InputSystem�� �ڵ�� ������ ����
        // InputSystem�� �̺�Ʈ ������� ������
        // Update���� �Էº�������� Ȯ���ϴ� ��� ��� ������ ���� ��� �̺�Ʈ�� Ȯ��
        // �޽����� ���� �޴� ��İ� �̺�Ʈ �Լ��� ���� �����ϴ� ��� ������ ����
    }

    private void OnMove(InputValue value)
    {
       Vector2 dir = value.Get<Vector2>();
    }

    private void OnJump(InputValue value)
    {
        bool isPress = value.isPressed;
    }
    // Move �Է¿� �����ϴ� OnMove �޽��� �Լ�
    //private void OnMove(InputValue value)
    //{
    //    Vector2 input = value.Get<Vector2>();
    //}
}