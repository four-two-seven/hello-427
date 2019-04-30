using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition += new Vector3(2.5f, 0, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.localPosition += new Vector3(1, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.localPosition += new Vector3(-1, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition += new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition += new Vector3(0, -1, 0) * Time.deltaTime;
        }
    }
}
