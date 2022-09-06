using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfShining : MonoBehaviour
{
    public float maxIntense;
    public float minIntense;
    public  float curIntense;
    public float intenseIncrement = 2.7f;

    private Light curLight;
    private bool isDirPositive;


    // Start is called before the first frame update
    void Start()
    {
        curLight = gameObject.GetComponent<Light>();
        isDirPositive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDirPositive)
        {
            curIntense += intenseIncrement;
            if (curIntense >= maxIntense)
            {
                isDirPositive = !isDirPositive;
            }
        }
        else {

            curIntense -= intenseIncrement;
            if (curIntense <= minIntense)
            {
                isDirPositive = !isDirPositive;
            }
        }

        curLight.intensity = curIntense;
    }
}
