using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public LightControl lc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            lc.PurpleLights();
        }

        if (Input.GetKeyDown("2"))
        {
            lc.RedLights();
        }

        if (Input.GetKeyDown("3"))
        {
            lc.GreenLights();
        }
        if (Input.GetKeyDown("4"))
        {
            lc.RandomLights();
        }
    }
}
