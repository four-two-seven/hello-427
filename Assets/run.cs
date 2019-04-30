using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(3, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(-3, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, 3);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, -3);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_Rigidbody2D.velocity = new Vector2(0, 0);
        }
    }
}
