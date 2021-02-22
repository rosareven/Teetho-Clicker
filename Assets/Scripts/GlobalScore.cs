using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Script to track the main score / how many top teeth have been clicked.
*/
public class GlobalScore : MonoBehaviour
{
    public static int score;
    // Start the game from scratch
    void Start()
    {
        score = 0;
    }
}
