using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheHorse : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 Vec;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vec=transform.localPosition;
        Vec.y+=Input.GetAxis("Jump")*Time.deltaTime*20;
        Vec.x+=Input.GetAxis("Horizontal")*Time.deltaTime*20;
        Vec.z+=Input.GetAxis("Vertical")*Time.deltaTime*20;
        transform.localPosition=Vec;
        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime);  
        }
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -10);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 10);  
        }
        if (Input.GetKey(KeyCode.A))  
        {  
            transform.Translate(0.1f, 0f, 0f);  
        }  
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.Translate(-0.1f, 0f, 0f);  
        }  
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.Translate(0.0f, 0f, -0.1f);  
        }  
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.Translate(0.0f, 0f, 0.1f);  
        }      
         
        
    }
}
