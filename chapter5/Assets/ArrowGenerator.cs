using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NewEmptyCSharpScript : MonoBehaviour
{
  public GameObject arrowPrefab;
  float span = 1.0f;
  float delta = 0f;

  void Update()
  {
    this.delta += Time.deltaTime;
    if (this.delta > this.span)
    {
      this.delta = 0;
      GameObject go = Instantiate(arrowPrefab);
      int px = Random.Range(-6, 7);
      go.transform.position = new Vector3(px, 7, 0);
    }
  }
}
