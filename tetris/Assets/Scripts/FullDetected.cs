using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullDetected : MonoBehaviour
{
    public int count = 0;
    public int level = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        count++;
    }
    private void OnTriggerExit2D(Collider2D other) {
        count--;
    }
}
