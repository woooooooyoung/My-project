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
    public void GameObjectBasic() // GameObjectBasic의 기본함수들 
    {
        // <게임오브젝트 접근>
        // 컴포넌트가 붗어있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능

        // 컴포넌트가 붙어있는 게임오브젝트
        // gameObject.name = "Player";    // 어제내준 과제
        // gameObject.name;            // 게임오브젝트의 이름접근
        // gameObject.active;          // 게임오브젝트의 활성화 여부 접근
        // gameObject.tag;             // 게임오브젝트의 태그 접근
        // gameObject.layer;           // 게임오브젝트의 레이어 접근

        // GameObject.Find("Player");                      // 이름으로 찾기 
        // GameObject.FindGameObjectWithTag("Player");     // tag로 찾지
        // GameObject.FindGameObjectsWithTag("Player");    // tag로 모두 찾기
        // 
        // GameObject obj = GameObject.Find("Player");
        // 
        // // <게임오브젝트 생성>
        // GameObject newObject = new GameObject();
        // 
        // // <게임오브젝트 삭제>
        // Destroy(obj); // 게임오브젝트 obj 삭제
        // Destroy(gameObject, 5f); // 5초 뒤 gameObject 삭제
        // 숫자를 안넣으면 즉시삭제 숫자를 넣으면 지연삭제
        
        // if (destroyGameObject != null)
        //     Destroy(destroyGameObject);
    }

    public void ComponentBasic()
    {
        // <게임오브젝트 내 컴포넌트 접근>
        // GetComponent<AudioSource>();                 // 컴포넌트에서 GetComponent를 사용할 경우 부착되어 있는 게임오브젝트를 기준으로 접근
        // GetComponents<AudioSource>();                // 게임 오브젝트의 컴포넌트 접근
        // audioSource.GetComponent<AudioSource>();     // 게임오브젝트의 컴포넌트 접근 
        // audioSource.GetComponents<AudioSource>();    // 게임오브젝트의 여러 컴포넌트 접근
        // //audioSource.gameObject.GetComponent<AudioSource>();    // == gameObject.GetComponent<AudioSource>();
        // 
        // GetComponentInChildren<AudioSource>();       // 자식게임오브젝트 포함 컴포넌트 접근
        // GetComponentsInChildren<AudioSource>();      // 자식게임오브젝트 포함 여러 컴포넌트 접근
        // gameObject.GetComponentInChildren<AudioSource>();   // 게임오브젝트의 자식게임오브젝트 포함 컴포넌트 접근
        // gameObject.GetComponentsInChildren<AudioSource>();  // 게임오브젝트의 자식게임오브젝트 포함 여러 컴포넌트 접근
        // 
        // GetComponent<AudioSource>();                 // 부모게임오브젝트 포함 컴포넌트 접근
        // GetComponents<AudioSource>();                // 부모게임오브젝트 포함 여러 컴포넌트 접근
        // gameObject.GetComponentInChildren<AudioSource>();   // 게임오브젝트의 부모게임오브젝트 포함 컴포넌트 접근
        // gameObject.GetComponentsInChildren<AudioSource>();  // 게임오브젝트의 부모게임오브젝트 포함 여러 컴포넌트 접근
        // 
        // // <컴포넌트 탐색>
        // FindObjectOfType<AudioSource>();  // 씬 내의 컴포넌트 탐색
        // FindObjectsOfType<AudioSource>(); // 씬 내의 모든 컴포넌트 탐색
        // // FindObjectsOfType<Monster>();  // 씬 내의 모든 몬스터 탐색
        // 
        // // <컴포넌트 추가> T
        // // Rigidbody rigid = new Rigidbody();   // 가능하나 의미 없음, 컴포넌트는게임오브젝트에 부착되어 동작함에 의미가 있음
        // gameObject.AddComponent<AudioSource>(); // 게임오브젝트에 컴포넌트 추가
        // AudioSource source = gameObject.AddComponent<AudioSource>(); // 게임오브젝트에 컴포넌트 추가
        // 
        // // <컴포넌트 삭제>
        // Destroy(source);
        // Destroy(GetComponent<Collider>());

    }











}
