using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour
{
    Vector2 posCamera;
    Vector2 posHielo;
    Vector2 posFuego;
    // Start is called before the first frame update
    void Start()
    {
        posCamera = gameObject.transform.position;
        posHielo = GameObject.Find("Hielo").transform.position;
        posFuego = GameObject.Find("Fuego").transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        posHielo = GameObject.Find("Hielo").transform.position;
        posFuego = GameObject.Find("Fuego").transform.position;
        float distance = Vector2.Distance(posHielo, posFuego);
        /* 
        we have a couple methods of changing the FOV(field of view) in my opinion the best one for us to
        use woulde be the one where we put the camera at a certain distance with a certain view and then we
        zoom in and out
        */
        // https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/
    }
}
