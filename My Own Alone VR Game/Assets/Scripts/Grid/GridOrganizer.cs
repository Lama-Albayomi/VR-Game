using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOrganizer : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject gridPrefabDrakGray;
    void Start()
    {
        GenerateGrid();
    }

    void Update()
    {

    }
    void GenerateGrid()
    {
        // generate a grid of 10x10
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                // Genrate a grid with a dark gray color then a light gray color
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        Instantiate(gridPrefabDrakGray, new Vector3(i, 0, j), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(gridPrefab, new Vector3(i, 0, j), Quaternion.identity);
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        Instantiate(gridPrefab, new Vector3(i, 0, j), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(gridPrefabDrakGray, new Vector3(i, 0, j), Quaternion.identity);
                    }
                }
            }
        }
    }
}
