using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
	public Transform doorTransform;
	public bool isDoorOpenned = false;
	public bool moving;
	float startingPos;
	float EndingPos;
    float step;
    float speed = 3f;
     float _delay = 0f;
	//transform door; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(moving){
                
            _delay += Time.deltaTime;   	  
       	    Quaternion target = Quaternion.Euler(doorTransform.rotation.eulerAngles.x,EndingPos, doorTransform.rotation.eulerAngles.z);
            doorTransform.rotation = Quaternion.Lerp(doorTransform.rotation, target, Time.deltaTime * speed);   
             Debug.Log(_delay );
            if(_delay > 1.2f) {
                isDoorOpenned = !isDoorOpenned; 
                _delay=0;
            	moving = false;
            }   	  
       }
    }

    public void OpenClose(string name){
         
          if(isDoorOpenned){
           EndingPos = -90f;
           moving = true;
           return;
        }

        if(name == "front"){
           EndingPos = -180f;
           moving = true;
        }else if(name == "back"){
           EndingPos = 0f;
           moving = true;
        }
    }
/*
     
*/
    
}
