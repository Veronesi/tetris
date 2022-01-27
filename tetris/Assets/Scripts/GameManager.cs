using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance { get; private set; }
  public GameObject[] pieces;

  public bool isForcePlus = false;
  public float force = 30f;
  public float forcePlus = 200f;
  public int SIZE_HORIZONTAL = 10;
  public int SIZE_VERTICAL = 20;
  public Transform staticPieces;
  public Transform levelDectections;
  void Awake()
  {
    instance = this;
  }

  void Start()
  {
    //SpawnPiece();
  }
  public void SpawnPiece()
  {
    isForcePlus = false;
    int i = Random.Range(0, pieces.Length);
    Instantiate(pieces[i], new Vector3(5f, 20f, 0f), Quaternion.identity);
  }
  public float getForce()
  {
    if (isForcePlus)
      return forcePlus;
    return force;
  }
  public void movePieces(Vector3 position, Transform pieces)
  {
    for (int i = pieces.childCount - 1; i >= 0; --i)
    {
      Transform child = pieces.GetChild(i);
      Vector3 oldPosition = child.position;
      child.SetParent(staticPieces.transform, false);
      child.position = oldPosition;
    }
    // check if level X is full
    for (int i = levelDectections.childCount - 1; i >= 0; --i)
    {
      Transform child = levelDectections.GetChild(i);
      FullDetected fullDetected = child.gameObject.GetComponent<FullDetected>();
      Debug.Log(fullDetected.level + " : "+ fullDetected.count);
    }
    
  }
}
