using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class RayScript : MonoBehaviour
{
    public Transform Pointer;
    Ray ray = new Ray();
    public float distance;
    private void LateUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 10f, Color.yellow);
        //  ray.origin = transform.position;
        //Vector3 directioinOfRay = new Vector3(1, -1, 0);

       
     
        if (Physics.Raycast(ray, distance) )
        {
      
            

        }
        
    }
}
