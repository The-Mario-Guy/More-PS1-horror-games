using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayandNIghtLighting : MonoBehaviour
{
    Vector3 rot=Vector3.zero;
        float degpersec= 0.86400f;

    // Update is called once per frame
    void Update()
    {
        rot.x = degpersec * Time.deltaTime;
        transform.Rotate(rot, Space.World);
    }
}
