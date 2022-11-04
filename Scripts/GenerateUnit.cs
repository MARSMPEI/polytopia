using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateUnit : MonoBehaviour
{
    public List<GameObject> Units;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Units[0], new Vector3(0.5f,1f,0.5f), Units[0].transform.rotation);
        Instantiate(Units[1], new Vector3(1.5f, 1f, 1.5f), Units[1].transform.rotation);
        
    }

    public void UnitTransformPosition(Vector3 newPosition, int index)
    {
        Units[index].transform.position = newPosition;
        Debug.Log("Unit [0] pisition " + Units[0].transform.position);
    }
    // Update is called once per frame

}
