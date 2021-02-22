using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Script to set up the game: spawn top teeth on a fixed array of x,y locations.
*/
public class TopToothSpawner : MonoBehaviour{
    public GameObject top_tooth; // The actual top tooth sprite goes here in Unity Editor.
    public Vector3[] topToothPosition = new Vector3[15];
    public GameObject[] topteeth = new GameObject[15];

    void Start(){
        FillTopToothPositions();
        SpawnTopTooth();
    }

    // List of 15 fixed locations for top teeth
    void FillTopToothPositions(){
        topToothPosition[0] = new Vector3(-2.06f,0.53f,1);
        topToothPosition[1] = new Vector3(0.07f,0.89f,1);
        topToothPosition[2] = new Vector3(1.27f,0.78f,1);
        topToothPosition[3] = new Vector3(-1.73f,0.66f,1);
        topToothPosition[4] = new Vector3(-1.48f,0.69f,1);
        topToothPosition[5] = new Vector3(-1.31f,0.78f,1);
        topToothPosition[6] = new Vector3(-1.02f,0.82f,1);
        topToothPosition[7] = new Vector3(-0.6f,0.86f,1);
        topToothPosition[8] = new Vector3(-0.22f,0.86f,1);
        topToothPosition[9] = new Vector3(0.38f,0.87f,1);
        topToothPosition[10] = new Vector3(0.67f,0.86f,1);
        topToothPosition[11] = new Vector3(0.98f,0.84f,1);
        topToothPosition[12] = new Vector3(1.58f,0.64f,1);
        topToothPosition[13] = new Vector3(1.86f,0.53f,1);
        topToothPosition[14] = new Vector3(2.06f,0.37f,1);
    }

    // Create an array of top teeth based on the fixed locations
    void SpawnTopTooth(){
        Quaternion rotation = new Quaternion(0,0,0,0);
        for(int i = 0;i < topToothPosition.GetLength(0);i++){
            topteeth[i] = Instantiate(top_tooth,topToothPosition[i],rotation);
            topteeth[i].SetActive(true);
            topteeth[i].name = "toptooth"+i;
        }
    }
}