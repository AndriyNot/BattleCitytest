using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public GameObject wallPrefab;
    public GameObject wallPrefab2;
    public GameObject basePrefab;
    public GameObject tankplayer;
   
    public GameObject[] titles;
  
    public GameObject pointbase;
    private float wallProbability = 0.4f;
    private float wallProbability2 = 0.05f;


    private void Start()
    {
        generateMap();
    }
    public void generateMap()
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (Random.value < wallProbability)
            {
                Instantiate(wallPrefab, titles[i].transform.position, Quaternion.identity);
            }
            if (Random.value < wallProbability2)
            {
                Instantiate(wallPrefab2, titles[i].transform.position, Quaternion.identity);
            }
           
                
            
        }

        Instantiate(tankplayer, new Vector2(-1.06634f, -4.51f), Quaternion.identity);
        Instantiate(basePrefab, pointbase.transform.position, Quaternion.Euler(0, 0, 180));


        
    }

}

