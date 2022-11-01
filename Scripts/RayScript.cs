using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class RayScript : MonoBehaviour
{
    public Transform Pointer;
    public Vector3 rayPositionVector;
    public string colliderTag;
    public GameObject Unit;
    Ray ray = new Ray();
    //  public float distance;
    private Vector3 upUnit;
    private void Start()
    {
        upUnit = new Vector3(0f, 1.5f, 0f); 
    }
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);
        //  ray.origin = transform.position;
        //Vector3 directioinOfRay = new Vector3(1, -1, 0);

       
     
        if (Physics.Raycast(ray , out RaycastHit hitInfo) )
        {
           
            colliderTag = hitInfo.collider.tag;
        //    Debug.Log(colliderTag);
            rayPositionVector = hitInfo.transform.position + upUnit;
      
        }
        if (Input.GetMouseButtonDown(0))
        {
            
     
                // Debug.Log(screenMousePosWithDepth);
                Unit.transform.position = rayPositionVector;
           
            // Debug.Log(screenMousePosWithDepth);
           // Unit.transform.position = rayPositionVector;
        }
    }
}





/*
           Debug.Log("hit normal " + hitInfo.normal);
           Debug.Log("hit distance " +(int)hitInfo.distance);
           Debug.Log("hit textureCoord2 " + hitInfo.textureCoord2);
           Debug.Log("hit textureCoord " + hitInfo.textureCoord);
           */
// Debug.Log("hit barycentricCoordinate " + hitInfo.barycentricCoordinate);
//   Debug.Log("hit collider " + hitInfo.collider); 
//    Debug.Log("hit transform " + hitInfo.transform.position);