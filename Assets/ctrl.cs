using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
  public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      float inputx=Input.GetAxisRaw("Horizontal");
      float inputy=Input.GetAxisRaw("Vertical");
      transform.Translate(speed*inputx*Time.deltaTime,speed*inputy*Time.deltaTime,0);

    }
}
