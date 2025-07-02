using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlrayerController : MonoBehaviour
{
  void Start()
  {
    Application.targetFrameRate = 60;
  }

  public void LButtonDown()
  {
    transform.Translate(-3, 0, 0);
  }

  public void RButtonDown()
  {
    transform.Translate(3, 0, 0);
  }
  void Update()
  {
    //왼쪽 화살표가 눌렀을 때
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      Debug.Log("왼쪽");
      transform.Translate(-3, 0, 0); // 왼쪽으로 '3' 움직인다.
    }
    //오른쪽 화살표가 눌렀을 때
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      Debug.Log("오른쪽");
      transform.Translate(3, 0, 0); //오른쪽으로 '3' 움직인다.
    }
  }
}
