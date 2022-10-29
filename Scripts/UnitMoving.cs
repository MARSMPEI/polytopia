using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMoving : MonoBehaviour
{ /*
    public Vector3 mousePos;
    public Vector3 mousePosClick;
    public GameObject Unit;
    void Update()
    {
       mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//изменяется все время == позиция мыши
        if (Input.GetMouseButtonDown(0))
        {
           // Transform myObject = transform;
            Vector3 screenMousePosWithDepth = new Vector3((int)Input.mousePosition.x/100+0.5f, 1f, (int)Input.mousePosition.z/100+ 0.5f);
           // Debug.Log(screenMousePosWithDepth);
            transform.position = screenMousePosWithDepth;
        }//Будет изменяться только тогда когда ты кликнул
    }
    */
    /*
    public Camera cam;
    public Vector3 pos = new Vector3(2, 0, 2);
    private void Start()
    {
        cam = GetComponent<Camera>();
        
    }
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
    }*/
    Ray ray = new Ray();
    
    private void Update()
    {
        ray.origin = transform.position;
        Vector3 directioinOfRay = new Vector3(1, -1, 0);
        ray.direction = directioinOfRay;
        Debug.DrawRay(transform.position, directioinOfRay * 10, Color.red);
        RaycastHit hit;
       if(Physics.Raycast(ray, out hit))
        {
        //    Debug.Log("hit");
        }

    }
}
