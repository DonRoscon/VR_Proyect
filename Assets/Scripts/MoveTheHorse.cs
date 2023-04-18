using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheHorse : MonoBehaviour
{
    // Start is called before the first frame updates
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public float moveSpeed = 10f;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.left * -moveSpeed * Time.deltaTime);
        //Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
}

