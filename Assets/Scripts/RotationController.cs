using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{

    public GameObject PlanetObject;
    public Vector3 RotationVector, scaleChange;


    void Update()
    {
        Debug.Log(Time.deltaTime);
        //code for rotating the planet
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);

        if (PlanetObject.transform.localScale.x >= 3)
        {
            //PlanetObject.transform.localScale -= new Vector3(0.01F, 0.01F, 0.005f);
        }
        else if (0 <= PlanetObject.transform.localScale.x || PlanetObject.transform.localScale.x <= 3)
        {
            PlanetObject.transform.localScale += new Vector3(0.01F, 0.01F, 0.005f);
        }
        
    }
    
}


/////////////////
///perfect code
///using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class RotationController : MonoBehaviour
// {

//     public GameObject PlanetObject;
//     public Vector3 RotationVector, scaleChange;


//     void Update()
//     {
//         Debug.Log(Time.deltaTime);
//         //code for rotating the planet
//         PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);

//         if (PlanetObject.transform.localScale.x >= 3)
//         {
//             //PlanetObject.transform.localScale -= new Vector3(0.01F, 0.01F, 0.005f);
//         }
//         else if (0 <= PlanetObject.transform.localScale.x || PlanetObject.transform.localScale.x <= 3)
//         {
//             PlanetObject.transform.localScale += new Vector3(0.01F, 0.01F, 0.005f);
//         }
        
//     }
// }

