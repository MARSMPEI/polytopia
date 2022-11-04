using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMoving : MonoBehaviour
{
    public GenerateUnit generateUnit;
   // public List<GameObject> Unit;
    public void Start()
    {
     generateUnit = GameObject.Find("BaseUnit(Clone)").GetComponent<GenerateUnit>();
    }
    public void UnitTransformPosition(Vector3 newPosition, int index)
    {
        //    generateUnit.Units[index].transform.position = newPosition;
        //Debug.Log("Unit [0] pisition " + generateUnit.Units[0].transform.position);
    }
}
