using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H15 : MonoBehaviour
{

    public Light candleLight;
    public float speed = 0.7f;
    public float lightSpeed = 1.0f;
    public Light sunLight;
    public float sunSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        candleLight.transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (candleLight.transform.position.x >= 1)
        {
            speed = -speed;
        }
        else if(candleLight.transform.position.x <= 0.8)
        {
            speed = -speed;
        }

        candleLight.intensity += Time.deltaTime * lightSpeed;
        if (candleLight.intensity >= 6)
        {
            lightSpeed = -lightSpeed;
        }
        else if(candleLight.intensity <= 2)
        {
            lightSpeed = -lightSpeed;
        }

        sunLight.transform.Rotate(Vector3.right, sunSpeed * Time.deltaTime);
    }
}