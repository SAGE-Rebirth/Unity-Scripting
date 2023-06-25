using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    public void SkyboxChange(Material material)
    {
        RenderSettings.skybox = material;
    }
}
