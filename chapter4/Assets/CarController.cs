using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController:MonoBehaviour
{
    float speed = 0f;
    Vector2 startPos;
    
    void Start()
    {
      Application.targetFrameRate = 60;
    }

    void Update()
    {
      //스와이프의 길이를 구한다.
      if(Input.GetMouseButtonDown(0))
      {
        this.startPos = Input.mousePosition;
      }
      else if (Input.GetMouseButtonUp(0))
      {
        //마우스 버튼에서 손가락을 떼었을 때 좌포
        Vector2 endPos = Input.mousePosition;
        float swipeLength = endPos.x - this.startPos.x;

        //스와이프 길이를 처음 속도로 변환한다.
        this.speed = swipeLength / 500.0f;

        //효과음을 재생한다.
        GetComponent<AudioSource>().Play();
      }
      transform.Translate(this.speed, 0 ,0); //이동
      this.speed *= 0.98f;                   //감속
    }
}
