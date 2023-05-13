using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    // Game
    public GameObject GameObject;
    public AudioSource audioSource;
    private void Start()
    {
        // GameObjectBasic();
        // ComponentBasic();
    }
    public void GameObjectBasic() // GameObjectBasic�� �⺻�Լ��� 
    {
        // <���ӿ�����Ʈ ����>
        // ������Ʈ�� �ʾ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���

        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        // gameObject.name = "Player";    // �������� ����
        // gameObject.name;            // ���ӿ�����Ʈ�� �̸�����
        // gameObject.active;          // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.tag;             // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;           // ���ӿ�����Ʈ�� ���̾� ����

        // GameObject.Find("Player");                      // �̸����� ã�� 
        // GameObject.FindGameObjectWithTag("Player");     // tag�� ã��
        // GameObject.FindGameObjectsWithTag("Player");    // tag�� ��� ã��
        // 
        // GameObject obj = GameObject.Find("Player");
        // 
        // // <���ӿ�����Ʈ ����>
        // GameObject newObject = new GameObject();
        // 
        // // <���ӿ�����Ʈ ����>
        // Destroy(obj); // ���ӿ�����Ʈ obj ����
        // Destroy(gameObject, 5f); // 5�� �� gameObject ����
        // ���ڸ� �ȳ����� ��û��� ���ڸ� ������ ��������
        
        // if (destroyGameObject != null)
        //     Destroy(destroyGameObject);
    }

    public void ComponentBasic()
    {
        // <���ӿ�����Ʈ �� ������Ʈ ����>
        // GetComponent<AudioSource>();                 // ������Ʈ���� GetComponent�� ����� ��� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �������� ����
        // GetComponents<AudioSource>();                // ���� ������Ʈ�� ������Ʈ ����
        // audioSource.GetComponent<AudioSource>();     // ���ӿ�����Ʈ�� ������Ʈ ���� 
        // audioSource.GetComponents<AudioSource>();    // ���ӿ�����Ʈ�� ���� ������Ʈ ����
        // //audioSource.gameObject.GetComponent<AudioSource>();    // == gameObject.GetComponent<AudioSource>();
        // 
        // GetComponentInChildren<AudioSource>();       // �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        // GetComponentsInChildren<AudioSource>();      // �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        // gameObject.GetComponentInChildren<AudioSource>();   // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        // gameObject.GetComponentsInChildren<AudioSource>();  // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        // 
        // GetComponent<AudioSource>();                 // �θ���ӿ�����Ʈ ���� ������Ʈ ����
        // GetComponents<AudioSource>();                // �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����
        // gameObject.GetComponentInChildren<AudioSource>();   // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ������Ʈ ����
        // gameObject.GetComponentsInChildren<AudioSource>();  // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����
        // 
        // // <������Ʈ Ž��>
        // FindObjectOfType<AudioSource>();  // �� ���� ������Ʈ Ž��
        // FindObjectsOfType<AudioSource>(); // �� ���� ��� ������Ʈ Ž��
        // // FindObjectsOfType<Monster>();  // �� ���� ��� ���� Ž��
        // 
        // // <������Ʈ �߰�> T
        // // Rigidbody rigid = new Rigidbody();   // �����ϳ� �ǹ� ����, ������Ʈ�°��ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        // gameObject.AddComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ �߰�
        // AudioSource source = gameObject.AddComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ �߰�
        // 
        // // <������Ʈ ����>
        // Destroy(source);
        // Destroy(GetComponent<Collider>());

    }











}
