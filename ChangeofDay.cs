using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeofDay : MonoBehaviour
{
    public float TimeofDay;
    public float DayDuration = 30f;

    public Light Sun;
   
    void Update()
    {
        TimeofDay += Time.deltaTime / DayDuration;
        if(TimeofDay >= 1)
        {
            
            TimeofDay -= 1;
           
        }
        Sun.transform.localRotation = Quaternion.Euler(TimeofDay * 360f, 180, 0);
    }

}
   

