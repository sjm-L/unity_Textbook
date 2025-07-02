using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ArrowController : MonoBehaviour
{
  void Start()
  {

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
  }
}
