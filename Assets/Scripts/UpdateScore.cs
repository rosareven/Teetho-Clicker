using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    Script to keep the score display updated real time
*/

public class UpdateScore : MonoBehaviour
{
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = "Score: "+GlobalScore.score;
    }
}
