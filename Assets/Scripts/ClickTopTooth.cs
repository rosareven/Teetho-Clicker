using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
    This script is embedded to individual top tooth for tracking mouse clicks and respawn time. 
    To save processing resource, top tooth respawn is handled by simply sending a clicked tooth's z layer to the back,
    and turn off its rendering to make it invisible. When it's time to respawn, it'll come back to the front z layer,
    and renderer is turned on again to make it visible.
*/ 

public class ClickTopTooth : MonoBehaviour
{
    private float timer = 0f; // Respawn timer for a top tooth
    private float spawnDelay = 5f; // How long to wait until a clicked top tooth respawns

    // Makes the top tooth invisible on click and gets sent to the back of the z layer, making it unclickable
    private void OnMouseDown() {
        if(GetComponent<Renderer>().enabled){
            GetComponent<Renderer>().enabled = false;
            transform.position += new Vector3(0,0,-12); // ensure disabled teeth don't interfere with other active teeth colliders
            GlobalScore.score++;
        }
    }

    private void Update() {
        if(GetComponent<Renderer>().enabled == false){
            timer += 1f * Time.deltaTime; // Starts the timer once a tooth is clicked and rendered invisible
        }
        if(GetComponent<Renderer>().enabled == false && timer > spawnDelay){
            GetComponent<Renderer>().enabled = true;
            transform.position += new Vector3(0,0,12);
            timer = 0f;
        }
    }
}
