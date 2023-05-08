using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheHorse : MonoBehaviour
{
    public Rigidbody  m_Rigidbody = new Rigidbody();
    // Start is called before the first frame updates
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public float moveSpeed = 10f;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            m_Rigidbody.MovePosition((Vector3)transform.position + Vector3.forward*Time.deltaTime * moveSpeed);
        if(Input.GetKey(KeyCode.DownArrow))
            m_Rigidbody.MovePosition((Vector3)transform.position + Vector3.back*Time.deltaTime * moveSpeed);
        if(Input.GetKey(KeyCode.LeftArrow))
            m_Rigidbody.MovePosition((Vector3)transform.position + Vector3.left*Time.deltaTime * moveSpeed);
        if(Input.GetKey(KeyCode.RightArrow))
            m_Rigidbody.MovePosition((Vector3)transform.position + Vector3.right*Time.deltaTime * moveSpeed);
    }
}

