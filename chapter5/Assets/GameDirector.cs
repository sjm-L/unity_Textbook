using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;             //ui를 사용하므로 추가

public class GameDirector:MonoBehaviour
{

  GameObject hpGauge;
  void Start()
  {
    this.hpGauge = GameObject.Find("hpGauge");
  }

  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
  }
}
