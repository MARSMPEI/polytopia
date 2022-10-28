using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GenerateLand : MonoBehaviour
{
    public List<GameObject> GroundBlock;
  
    
    public int SizeOfMap;
    private int lenghtOfLand;
   
    void Start()
    {
        lenghtOfLand = 3 * SizeOfMap;
        for (int i = 0; i < lenghtOfLand ; i = i + 3)
         {
             for (int j = 0; j < lenghtOfLand; j = j+3)
             {

                SpawnBlockOfMap(i, j);
             }
         }
        
       
        //  Instantiate(GroundBlock[0]);
    }
    private void SpawnBlockOfMap(int pos_x, int pos_y)
    {
       int indexOfMapBlock  = GeneratorOfIndex();
        for (int i = 0; i <  3; i ++)
        {
            for (int j = 0; j < 3; j ++)
            {

                Vector3 spawnGroundPosition = SpawnPosition(pos_x, -0.5f, pos_y, i, j);
                Instantiate(GroundBlock[indexOfMapBlock], spawnGroundPosition, GroundBlock[indexOfMapBlock].transform.rotation);
                
            }
        }
        
    }
    
    private int GeneratorOfIndex()
    {   
        return ((int)Random.Range(0, GroundBlock.Count));
    }
  
    public Vector3 SpawnPosition(int pos_x, float pos_y, int pos_z, int i, int j)
    {
        
        return (new Vector3(pos_x + i + 0.5f, pos_y, pos_z + j + 0.5f));
    }
}
