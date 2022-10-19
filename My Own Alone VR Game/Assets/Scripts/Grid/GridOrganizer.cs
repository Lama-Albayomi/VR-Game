using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOrganizer : MonoBehaviour
{
    public GameObject gridPrefab;
    public GameObject gridPrefabDrakGray;
    public int gridSize = 10;
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
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                // Genrate a grid with a dark gray color then a light gray color
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        GameObject grid = Instantiate(gridPrefabDrakGray,this.transform);
                        grid.transform.position = new Vector3(i, 0, j);

                    }
                    else
                    {
                        GameObject grid = Instantiate(gridPrefab,this.transform);
                        grid.transform.position = new Vector3(i, 0, j);
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        GameObject grid = Instantiate(gridPrefab,this.transform);
                        grid.transform.position = new Vector3(i, 0, j);
                    }
                    else
                    {
                        GameObject grid = Instantiate(gridPrefabDrakGray,this.transform);
                        grid.transform.position = new Vector3(i, 0, j);
                    }
                }
            }
        }
        // sent the grid to the center of the scene
        transform.position = new Vector3(-gridSize / 2, 0, -gridSize / 2);
    }
}
