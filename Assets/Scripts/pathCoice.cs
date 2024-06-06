using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pathCoice : MonoBehaviour
{
    List<int> choices = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0};
    private int index = 0;
    public Camera cam;
    private bool traversing;
    // Start is called before the first frame update
    void Start()
    {  
       
    }

    // Update is called once per frame
    void Update()
    {
        if (traversing)
        {
            cam.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -100);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "1")
        {
            choices.Insert(index,1);
            Debug.Log(choices[index]);
            Debug.Log(index);
            index++;
            traversing = false;
            cam.transform.position = new Vector3(32, 0) + cam.transform.position;

        }
        if (other.tag == "2")
        {
            choices.Insert(index,2);
            Debug.Log(choices[index]);
            Debug.Log(index);
            index++;
            traversing = false;
            cam.transform.position = new Vector3(-32, 0) + cam.transform.position;
            
            
        }
        if (other.tag == "3")
        {
            choices.Insert(index,3);
            Debug.Log(choices[index]);
            Debug.Log(index);
            index++;
            traversing = false;
            cam.transform.position = new Vector3(0, 16) + cam.transform.position;
            
            
        }

        if (other.tag == "traversal-left")
        {
            choices.Insert(index,2);
            traversing = true;
            index++;
            this.transform.position = this.transform.position + new Vector3(-8, 0, 0);
        }
        if (other.tag == "traversal-right")
        {
            choices.Insert(index,1);
            traversing = true;
            index++;
            this.transform.position = this.transform.position + new Vector3(8, 0, 0);
        }
    
        if (other.tag == "traversal-up")
        {
            choices.Insert(index,3);
            traversing = true;
            index++;
            this.transform.position = this.transform.position + new Vector3(0, 4.5f, 0);
        }
        
        
    }
    
}
