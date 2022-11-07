using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverLight : MonoBehaviour
{
    void update()
    {
        this.GetComponent<Material>().EnableKeyword("_EMISSION");
        this.GetComponent<Material>().SetColor("EmissionColor", Color.green);
    }
}
