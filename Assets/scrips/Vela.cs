using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vela : MonoBehaviour
{

    //private Transform camTransform; //

    public Light light;// intensidad de la vela 
    public float intensidad = 0;
    private float min = 1 , max = 2;
    private int delay = 0;


    // Start is called before the first frame update
    void Start()
    {
        // camTransform = this.GetComponent<camTransform>();

        // Debub.Log(camTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (delay == 15)
        {
            intensidad = Random.Range(min, max);
            light.intensity = intensidad;
            delay = 0;

        }
        

        delay++;
    }
}
