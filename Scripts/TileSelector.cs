using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelector : MonoBehaviour
{
    public GameObject tileHighlightPrefab;
    public GenerateUnit generateUnit;
    private GameObject tileHighlight;


    public Vector3 newPosition;
    private Vector3 upUnit;     // Start is called before the first frame update
    void Start()
    { 
        
        Vector2Int gridPoint = Geometry.GridPoint(0, 0);
        Vector3 point = Geometry.PointFromGrid(gridPoint);
        tileHighlight = Instantiate(tileHighlightPrefab, point, Quaternion.identity, gameObject.transform);
        tileHighlight.SetActive(false);
        generateUnit = GameObject.Find("UnitGenerator").GetComponent<GenerateUnit>();

        upUnit = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 point = hit.point;
            Vector2Int gridPoint = Geometry.GridFromPoint(point);

            tileHighlight.SetActive(true);
            tileHighlight.transform.position =Geometry.PointFromGrid(gridPoint);
            newPosition = tileHighlight.transform.position + upUnit;
        }
        else
        {
            tileHighlight.SetActive(false);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            generateUnit.UnitTransformPosition(newPosition, 0);
        }
        
    }
    public void EnterState()
    {
        enabled = true;
    }
}
