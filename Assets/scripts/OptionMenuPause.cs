using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionMenuPause : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsPointerOverUIObject(Vector2 touchPos)
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
    
        eventDataCurrentPosition.position = touchPos;
    
        List<RaycastResult> results = new List<RaycastResult>();
    	
    
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
 		
        return results.Count > 0;
    }    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
	        if(IsPointerOverUIObject(Input.mousePosition))
	        {  
	            Debug.Log("UI");//클릭 처리
                Time.timeScale = 0.0f;
	        }
        }
    }
}
