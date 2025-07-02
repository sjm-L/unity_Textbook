using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ArrowController : MonoBehaviour
{
  GameObject player;
  void Start()
  {
    this.player = GameObject.Find("player_0");
  }

  void Update()
  {
    //프레임마다 등속으로 낙하시킨다.
    transform.Translate(0, -0.1f, 0);

    //화면 빆으로 나오면 오브젝트를 소멸시킨다
    if (transform.position.y < -5.0f)
    {
      Destroy(gameObject);
    }

    //출돌판정
    Vector2 p1 = transform.position;              //화살의 중심 좌표
    Vector2 p2 = this.player.transform.position;  //플레이어의 중심 좌표
    Vector2 dir = p1 - p2;
    float d = dir.magnitude;
    float r1 = 0.5f;                              //화살의 반지름
    float r2 = 1.0f;                              //플레이어의 반지름

    if (d < r1 + r2)
    {
      //감독 스크립트에 플레이어어ㅣ 화살이 충돌했다고 전달한다.
      GameObject director = GameObject.Find("GameDirector");
      director.GetComponent<GameDirector>().DecreaseHp();
      //출돌한 경우는 화살을 지운다.
      Destroy(gameObject);
    }
  }
}
