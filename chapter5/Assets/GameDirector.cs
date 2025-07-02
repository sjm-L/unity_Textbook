using UnityEngine;
using System.Collcetions;
using System.Collcetione.Generic;
using UnityEngine.UI;             //ui를 사용하므로 추가

public class GameDirector
{

  GameObject hpGauge;
  void Start()
  {
    this.hpGauge = GameObect.Find("hpGauge");
  }

  public void DecreaseHp()
  {
    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
  }
}
