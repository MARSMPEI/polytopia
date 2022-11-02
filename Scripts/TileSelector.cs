using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelector : MonoBehaviour
{
    public GameObject tileHighlightPrefab;

    private GameObject tileHighlight;
    // Start is called before the first frame update
    void Start()
    { 
        
        Vector2Int gridPoint = Geometry.GridPoint(0, 0);
        Vector3 point = Geometry.PointFromGrid(gridPoint);
        tileHighlight = Instantiate(tileHighlightPrefab, point, Quaternion.identity, gameObject.transform);
        tileHighlight.SetActive(false);
        
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
            tileHighlight.transform.position =
                Geometry.PointFromGrid(gridPoint);
        }
        else
        {
            tileHighlight.SetActive(false);
        }
        /*
        if (Input.GetMouseButtonDown(0))
        {
            GameObject selectedPiece =
                GameManager.instance.PieceAtGrid(gridPoint);
            if (GameManager.instance.DoesPieceBelongToCurrentPlayer(selectedPiece))
            {
                GameManager.instance.SelectPiece(selectedPiece);
                // Опорная точка 1: сюда мы позже добавим вызов ExitState
            }
        }
        */
    }
    public void EnterState()
    {
        enabled = true;
    }
}
