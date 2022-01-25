using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance { get; private set; }
  public int SIZE_HORIZONTAL = 10;

  void Awake()
  {
    instance = this;
  }

  void Start()
  {

  }

  void Update()
  {

  }
}
