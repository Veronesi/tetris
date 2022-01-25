using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float force = 30f;
    public int verticalSize = 2;
    public int horizontalSize = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.down * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
