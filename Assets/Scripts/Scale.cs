using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{

    public GameObject PlanetObject;
    public Vector3 scaleChange;
    int x=0;

    void Update()
    {
        // if (PlanetObject.transform.localScale.x >= 3)
        // {
        //     //PlanetObject.transform.localScale -= new Vector3(0.01F, 0.01F, 0.005f);
        // }
        // else 
        // if ((0 <= PlanetObject.transform.localScale.x || PlanetObject.transform.localScale.x <= 3) && x<=100)
        // {
        //     PlanetObject.transform.localScale += new Vector3(0.01F, 0.01F, 0.005f);
        //     x++;
        // }

        if (x<=500)
        {
            PlanetObject.transform.localScale += new Vector3(0.01F, 0.01F, 0.005f);
            x++;
        }
        
    }
}
