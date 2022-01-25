using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
  public bool canMove = true;
  public Piece piece;
  public int rotation = 0;
  public Transform child;
  void Start()
  {
    piece = gameObject.GetComponent<Piece>();
  }

  void Update()
  {
    if (canMove)
    {
      if (Input.GetKeyDown("d"))
      {
        if (rotation == 90 || rotation == 270)
        {
          if (transform.position.x+ piece.verticalSize < GameManager.instance.SIZE_HORIZONTAL)
            transform.position += new Vector3(1f, 0, 0);
        }
        else
        {
          if (transform.position.x + piece.horizontalSize < GameManager.instance.SIZE_HORIZONTAL)
            transform.position += new Vector3(1f, 0, 0);
        }
      }

      if (Input.GetKeyDown("a"))
      {
          if (transform.position.x > 0)
          {
            transform.position += new Vector3(-1f, 0, 0);
          }

      }
      if (Input.GetKeyDown("w"))
      {
        /*
            ROTATE ELEMENTS 
            0 deg   (0, 0)
            90 deg  (SIZE_VERTICAL, 0)
            180 deg (SIZE_HORIZONTAL, SIZE_VERTICAL)
            270 deg (0, SIZE_HORIZONTAL)
        */
        switch (rotation)
        {
          case 0:
            child.Rotate(0f, 0f, 90f, Space.Self);
            child.position += new Vector3(piece.verticalSize, 0, 0);
            rotation = 90;
            break;
          case 90:
            child.Rotate(0f, 0f, 90f, Space.Self);
            child.position += new Vector3(piece.horizontalSize - piece.verticalSize, piece.verticalSize, 0);
            rotation = 180;
            break;
          case 180:
            child.Rotate(0f, 0f, 90f, Space.Self);
            child.position += new Vector3(-piece.horizontalSize, piece.horizontalSize - piece.verticalSize, 0);
            rotation = 270;
            break;
          case 270:
            child.Rotate(0f, 0f, 90f, Space.Self);
            child.position += new Vector3(0, -piece.horizontalSize, 0);
            rotation = 0;
            break;
        }
      }
    }
  }
  private void OnCollisionEnter2D(Collision2D collision)
  {
    canMove = false;
  }
}


