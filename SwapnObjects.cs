/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class SwapnObjects : MonoBehaviour
{
    public GameObject prefab;
    public ChangeofDay changeofDay;

    public void Awake()
    {
        changeofDay = GetComponent<ChangeofDay>();
    }
    
  public void Update()
    {
        if (changeofDay.TimeofDay == 0.1)
        {
            var position = new Vector3(Random.Range(-18.0f, 2.0f), 0, Random.Range(-6.0f, -14.0f));
            Instantiate(prefab, position, Quaternion.identity);
        }
        
    }

    
}*/
