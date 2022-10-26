using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLand : MonoBehaviour
{
    public List<GameObject> GroundBlock;
    public int lenghtOfLand = 1;
    int indexOfGround;
    void Start()
    {
       
        for (int i = 0; i < lenghtOfLand; i++)
        {
            for (int j = 0; j < lenghtOfLand; j++)
            {
                Vector3 spawnGroundPosition = new Vector3(i+0.5f, -0.5f, j+0.5f);
                Instantiate(GroundBlock[GeneratorOfIndex()], spawnGroundPosition, GroundBlock[GeneratorOfIndex()].transform.rotation);
            }
        }

    }
    private void Update()
    {
       
    }
    private int GeneratorOfIndex()
    {   
        return ((int)Random.Range(0, GroundBlock.Count));
    }
    // Update is called once per frame
   
}
