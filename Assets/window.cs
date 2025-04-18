using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    public Transform rightWindowTransform;
    public Transform leftWindowTransform2;
	public bool isWindowOpenned = false;
	public bool moving;
    public float closeAngle;
    public float openAngle;
	float rightEndingYAngle;
	float leftEndingYAngle;

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
       	    Quaternion target1 = Quaternion.Euler(rightWindowTransform.rotation.eulerAngles.x, rightEndingYAngle, rightWindowTransform.rotation.eulerAngles.z);
       	    Quaternion target2 = Quaternion.Euler(leftWindowTransform2.rotation.eulerAngles.x, leftEndingYAngle, leftWindowTransform2.rotation.eulerAngles.z);
            rightWindowTransform.rotation = Quaternion.Lerp(rightWindowTransform.rotation, target1, Time.deltaTime * speed);   
            leftWindowTransform2.rotation = Quaternion.Lerp(leftWindowTransform2.rotation, target2, Time.deltaTime * speed);   
             Debug.Log(_delay );
            if(_delay > 1.2f) {
                isWindowOpenned = !isWindowOpenned; 
                _delay=0;
            	moving = false;
            }   	  
       }
    }

    public void OpenClose(string name){
         
          if(isWindowOpenned){
           rightEndingYAngle = closeAngle+180f;
           leftEndingYAngle = closeAngle;
           moving = true;
           return;
        }

        if(name == "front"){
        
            rightEndingYAngle = -openAngle;
           leftEndingYAngle = -openAngle;
           moving = true;
        }else if(name == "back"){
         
            rightEndingYAngle = openAngle;
           leftEndingYAngle = openAngle;
           moving = true;
        }
    }
}
