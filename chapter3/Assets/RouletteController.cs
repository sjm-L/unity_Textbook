using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour
    {
      //회전 속도
      float rotSpeed = 0f;
      void Start()
      {
        //프레임레이트를 60으로 고정한다.
        Application.targetFrameRate = 60;
        Debug.Log("시작");
      }
      void Update()
      {
        //클릭하면 회전 속도를 설정한다.
        if(Input.GetMouseButtonDown(0))
        {
          this.rotSpeed = 10;
        }
        //회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);
        Debug.Log("돌고있음");
        this.rotSpeed *= 0.99f;
      }
    }