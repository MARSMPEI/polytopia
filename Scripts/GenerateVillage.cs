using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateVillage : MonoBehaviour
{
    public List<GameObject> Village;
    // Start is called before the first frame update
    private GenerateLand generateLandScript;
    void Start()
    {
        generateLandScript = GameObject.Find("VillageGenerator").GetComponent<GenerateLand>();

        Vector3 spawnGroundPositionVillage = new Vector3(1.5f, 0.5f, 1.5f);
        Instantiate(Village[0], spawnGroundPositionVillage, Village[0].transform.rotation);
    }
    
    
}

