using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    // 리지드 바디 객체를 받을 변수 선언
    Rigidbody2D rg;
    void Start()
    {
        // GetComponent를 이용하여 컴포넌트를 가져오는데, 그떄 Rigidbody2D 컴포넌트를 가져와 최초 프로그램이 실행될때 변수에 담아준다
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input의 GetMouseButtonDown은 마우스를 눌렀을때, 0을 넣어주면 왼쪽 마우스버튼 1은 오른쪽 마우스 버튼을 눌렀을때를 의미한다.
        if (Input.GetMouseButtonDown(0))
        {
            // rb.velocity는 리지드바디에서 속도를 의미한다.
            // Vector2.up이라는 것을 넣어 점프했을떄 위로 힘을 주도록하는데,
            // Vector2.up는 좌표상 (0,1)을 의미한다. Vector2는 (x,y,z)로 방향을 조정할 수 있다. 
            // Vector2.up * 3을 하게되면 (0, 3)이 되고 위쪽 y축 방향으로 3만큼의 속도를 가지게된다.
            rb.velocity = Vector2.up * 3;
        }
        Debug.Log("Update 입니다.");
    }
}
