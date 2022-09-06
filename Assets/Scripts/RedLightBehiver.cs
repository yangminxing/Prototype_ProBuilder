using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightBehiver : MonoBehaviour
{
    public GameObject redLightBulb;

    private Light curLight;
    
    // Start is called before the first frame update
    void Start()
    {
        curLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Material redLightBulbMat = redLightBulb.GetComponent<Material>();
        //float emission = redLightBulbMat.em
    }
}
