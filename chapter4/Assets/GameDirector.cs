using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; //TextMesPro를 사용하는데 필요하다.

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
      this.car = GameObject.Find("car_0");
      this.flag = GameObject.Find("flag_0");
      this.distance = GameObject.Find("distance");
    }

    void Update()
    {
      float length = this.flag.transform.position.x - this.car.transform.position.x;
      this.distance.GetComponent<TextMesProUGUI>().test = "Distance:"+length.ToString("F2")+"m";
    }
}
