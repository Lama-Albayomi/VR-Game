using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOrganizer : MonoBehaviour {
    public GameObject gridPrefab;
    public GameObject gridPrefabDrakGray;
    public int gridSize = 10;
    public GameObject[,] grid = new GameObject[10, 10];

    void Start(){
        GenerateGrid();
    }

    void Update(){

    }
    void GetPieceatPosition(Vector3 position){

    }
    void GenerateGrid(){
        // generate a grid of 10x10
        for (int i = 0; i < gridSize; i++){
            for (int j = 0; j < gridSize; j++){
                // Genrate a grid with a dark gray color then a light gray color
                if (i % 2 == 0){
                    if (j % 2 == 0){
                        GameObject gridInstance = Instantiate(gridPrefabDrakGray,this.transform);
                        gridInstance.transform.position = new Vector3(i, 0, j);
                        //grid[i, j] = gridInstance;
                    }
                    else{
                        GameObject gridInstance = Instantiate(gridPrefab,this.transform);
                        gridInstance.transform.position = new Vector3(i, 0, j);
                        //grid[i, j] = gridInstance;
                    }
                }
                else{
                    if (j % 2 == 0){
                        GameObject gridInstance = Instantiate(gridPrefab,this.transform);
                        gridInstance.transform.position = new Vector3(i, 0, j);
                        //grid[i, j] = gridInstance;
                    }
                    else{
                        GameObject gridInstance = Instantiate(gridPrefabDrakGray,this.transform);
                        gridInstance.transform.position = new Vector3(i, 0, j);
                        //grid[i, j] = gridInstance;
                    }
                }
            }
        }
        // sent the grid to the center of the scene
        transform.position = new Vector3(-gridSize / 2, 0, -gridSize / 2);
    }
}
