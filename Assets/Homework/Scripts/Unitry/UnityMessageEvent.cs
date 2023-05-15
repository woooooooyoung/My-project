using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessageEvent : MonoBehaviour
{
    /************************************************************************
	 * ����Ƽ�޽��� �̺�Ʈ�Լ�
	 * 
	 * ����Ƽ�� ������ �޽����� �����ϴ� �Լ�
	 * ������ ��� ����Ƽ�޽����� ����������, �������� ���� ��� ������
	 * ��ũ��Ʈ�� ����Ƽ ������ ������ �޽����� �����Ͽ� �ڽ��� �ൿ�� ����
	 ************************************************************************/
    
    private void Awake()
    {
        // ������ �ȵɽ� 1ȸ ȣ��Ǵ� �Լ��� �Ȱ����� ���� ����
        // ��ũ��Ʈ�� ���� ���ԵǾ��� �� 1ȸ ȣ��Ǵ� �Լ�
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ���

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //		  (���ӻ�Ȳ�� ������ ������ �ʱ�ȭ �۾�)
        // ex) ������ �ʱ�ȭ, ������Ʈ ������ ����
        // ��ŸƮ�� ����(������Ʈ�ϴ�)�Լ� ������ �� �ѹ��� ȣ��Ǵ� ���������� ȣ��Ǵ� �Լ����� �����ũ�� ������ �غ� �ȵž��־ ȣ��Ǵ� �Լ���
        Debug.Log("Awake");
    }
    private void Start()
    {
        // ��ũ��Ʈ�� ���� ó������ Update�ϱ� ������ 1ȸ ȣ���
        // ������ ��� ������ �ȴ��� ���� ������ ȣ���ϴ� �Լ�(���͵��� �÷��̾� ���� ���õ��ִ� ��찡 �ƴ� ���� �� ���õǾ߸� ȣ���)
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ��� ȣ����� ����

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        //		  (���ӻ�Ȳ�� ������ �� �� �ִ� �۾�)
        // ex) ������ �÷��̾� Ÿ�ټ���
        Debug.Log("Start");
    }

    private void OnEnable()
    {


        // ��ũ��Ʈ�� Ȱ��ȭ�� ������ ȣ��
        // �����Ѵ� �ϸ� OnEnable�� ȣ�� ������ �ȵȴٸ� OnDisable�� ȣ���

        // ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾� ����
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ȣ��



        // ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾� ����
        Debug.Log("OnDisable");
    }


    private void Update()
    {
        // Update�� �⺻������ �Ķ����� ���� �Լ�

        // ������ �����Ӹ��� ȣ��

        // ���� : �ٽ� ���� ���� ����


        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // ���� ��� ���ӿ�����Ʈ�� Update�� ����� �� ȣ��1
        // ��ó���� �ʿ��Ѱ� LateUpdate
        // ���� : ������������ ���� ����� �ʿ��� ������ �ִ� ��� ����
        // ex) �÷��̾��� ��ġ�� ������ �Ŀ� ī�޶��� ��ġ ����
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        // ����Ƽ�� �������� �����ð����� ȣ�� (�⺻ 1�ʿ� 50��)
        // Update�� �ٸ��� �����Ӵ� ����� �����ð��� ����
        // ��, ���ӷ��� ��, ������ ���� �۾��� FixedUpdate�� �������� �ʾƾ� ��

        // ���� : ���ɰ� ������ ����� ������ ���� �ʾƾ� �ϴ� �۾�
        // ex) ������ ó��
        Debug.Log("FixedUpdate");
    }


    private void OnDestroy()
    {
        
        // ��ũ��Ʈ�� �����Ǿ��� ��� ȣ��
        // ������ü�� ������� ȣ��

        // ���� : ��ũ��Ʈ�� ������ ����
        Debug.Log("OnDestory");
    }
}