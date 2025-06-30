using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController:MonoBehaviour
{
    float speed = 0f;
    
    void Start()
    {
      Application.targetFrameRate = 60;
    }

    void Update()
    {
      if(Input.GetMouseButton(0)) //마우스를 클릭하면
      {
        this.speed = 0.2f;            //처음 속도를 설정 한다.
      }
      transform.Translate(this.speed, 0 ,0); //이동
      this.speed *= 0.93f;                   //감속
    }
}
