using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        // transform 속성은 기본적으로 있는 속성이기 때문에 GetComponent<>()로 가져올 필요가 없다
        // 오브젝트의 좌표가 찍혀져나온다.
        // (x, y, z)의 좌표가 로그에 찍히게되는데, 이때 2D게임의 경우는 z좌표는 필요없기 때문에 0으로 설정해준다.
        Debug.Log(transform.position);

        // Rigidbody2D의 경우 좌표를 x, y축 존재해 Vector2 컴포넌트를 사용하지만
        // 이번에 추가한 파이프 오브젝트는 인스펙터를 확인해보면 x, y, z 3개의 좌표가 포함되어있기 때문에 Vector3 컴포넌트를 사용한다.
        transform.position += Vector3.left * Time.deltaTime; // Vector3.left는 내부적으로 (-1, 0, 0)을 의미한다.
        /*
            transform.position += Vector3.left; <-- 왼쪽 처럼 짜면 문제가하나있다.
            update 함수는 프레임마다 실행하게되는데, 문제는 스마트폰, 컴퓨터 성능에 따라 다르게 동작하게된다.
            이는 3fps, 6fps 성능을 가진 각각의 컴퓨터가 있을떄 서로 다른 컴퓨터 성능으로 인해
            어떤 컴퓨터는 3fps여서 update함수가 3번만 동작하고 어떤컴퓨터는 6fps 성능을 가져 update함수가 6번 동작하게된다.
            이렇게된다면 성능이 좋을수록 더 좋은 상황이 연출될 수 있게된다.
            이를 해소하기위해 유니티에선 Time.deltaTime이라는 것을 지원해준다 
            Time.deltaTime은 지난 프레임이 완료되는데까지 걸린 시간으로 FPS 보정용으로 사용된다. 
            3fps인 게임은 1초에 3장씩 프레임이 지나니까 1/3초가 되는 것
            6fps인 게임은 1초에 6장씩 프레임이 지나니까 1/6초가 되는 것 
            이렇게 deltaTime을 곱해줌으로서 어느환경에 있던 같은 결과를 내게 해줄 수 있다. 
        */

    }
}
