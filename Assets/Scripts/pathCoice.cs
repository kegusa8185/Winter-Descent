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
    public bool goingUp = true;
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
            choices.Insert(8-index,1);
            index++;
            traversing = false;
            if (goingUp)
            {
                cam.transform.position = new Vector3(32, 0) + cam.transform.position;
                this.transform.position = this.transform.position + new Vector3(8, 0, 0);
            }
            other.isTrigger = false;
            
        }
        if (other.tag == "2")
        {
            choices.Insert(8-index,2);
            index++;
            traversing = false;
            if (goingUp)
            {
                
                cam.transform.position = new Vector3(-32, 0) + cam.transform.position;
                this.transform.position = this.transform.position + new Vector3(-8, 0, 0);
            }
            other.isTrigger = false;
            



        }
        if (other.tag == "3")
        {
            choices.Insert(8-index,3);
            index++;
            traversing = false;
            if (goingUp)
            {
                
                cam.transform.position = new Vector3(0, 16) + cam.transform.position;
                this.transform.position = this.transform.position + new Vector3(0, 4.5f, 0);
            }
            other.isTrigger = false;
        }

        if (other.tag == "traversal-left")
        {
            choices.Insert(8-index,2);
            traversing = true;
            index++;
            if (goingUp)
            {
                this.transform.position = this.transform.position + new Vector3(-8, 0, 0);
            }
            other.isTrigger = false;
        }
        if (other.tag == "traversal-right")
        {
            choices.Insert(8-index,1);
            traversing = true;
            index++;
            if (goingUp)
            {
                this.transform.position = this.transform.position + new Vector3(8, 0, 0);
            }
            other.isTrigger = false;
        }
    
        if (other.tag == "traversal-up")
        {
            choices.Insert(8-index,3);
            traversing = true;
            index++;
            if (goingUp)
            {
                
                this.transform.position = this.transform.position + new Vector3(0, 4.5f, 0);
            }
            other.isTrigger = false;
        }
        
        if (other.tag == "exit-traversal-left")
        {
            choices.Insert(8-index,2);
            traversing = false;
            index++;
            if (goingUp)
            {
                cam.transform.position = new Vector3(-16, 0,-100) + other.transform.position;
                this.transform.position = this.transform.position + new Vector3(-8, 0, 0);
            }
            other.isTrigger = false;
            
        }
        if (other.tag == "exit-traversal-right")
        {
            choices.Insert(8-index,1);
            traversing = false;
            index++;
            if (goingUp)
            {
                this.transform.position = this.transform.position + new Vector3(8, 0, 0);
                cam.transform.position = new Vector3(16, 0,-100) + other.transform.position;
            }
            other.isTrigger = false;
        }
    
        if (other.tag == "exit-traversal-up")
        {
            choices.Insert(8-index,3);
            traversing = false;
            index++;
            if (goingUp)
            {
                cam.transform.position = new Vector3(0, 9,-100) + other.transform.position;
                this.transform.position = this.transform.position + new Vector3(0, 4.5f, 0);
            }
            other.isTrigger = false;
        }
        if (other.tag == "cam-left")
        {
            traversing = false;
            if (goingUp)
            {
                cam.transform.position = new Vector3(-16, 0, -100) + other.transform.position;
                this.transform.position = this.transform.position + new Vector3(-8, 0, 0);
            }
            other.isTrigger = false;
            
        }
        if (other.tag == "cam-right")
        {
            index++;
            if (goingUp)
            {
                this.transform.position = this.transform.position + new Vector3(8, 0, 0);
                cam.transform.position = new Vector3(16, 0,-100) + other.transform.position;
            }
            other.isTrigger = false;
            
        }
    
        if (other.tag == "cam-up")
        {
            index++;
            if (goingUp)
            {
                cam.transform.position = new Vector3(0, 9,-100) + other.transform.position;
                this.transform.position = this.transform.position + new Vector3(0, 4.5f, 0);
            }
            other.isTrigger = false;
        }
    }
    
}
