using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        // float v =Input.GetAxisRaw("Vertical");
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, 0, 0) * speed * Time.deltaTime;
        transform.position = curPos + nextPos;
    }
}
