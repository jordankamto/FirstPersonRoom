using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	bool drawButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth/2,Camera.main.pixelHeight/2,0));
       RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100)){
                    Debug.DrawLine(ray.origin, hit.point);
                    if(hit.transform.tag == "openner"){
                    	drawButton = true;
                    	if(Input.GetKeyDown(KeyCode.F)){
                    		 Debug.Log("Clicked the button with text");
                    		 if(hit.transform.parent.gameObject.GetComponent<door>() != null){
                    		      hit.transform.parent.gameObject.GetComponent<door>().OpenClose(hit.transform.name);
                    		   }else if(hit.transform.parent.gameObject.GetComponent<window>() != null){
                    		      hit.transform.parent.gameObject.GetComponent<window>().OpenClose(hit.transform.name);
                    		   }
                    	}
                    }else{
                    	drawButton = false;
                    }
               }
    }

     void OnGUI()
    {
         if(drawButton){
         	 if (GUI.Button(new Rect((Camera.main.pixelWidth/2)-75,Camera.main.pixelHeight/2, 150, 30), "F pour ouvrir la porte")){
               
              }
         }
       
    }
}
