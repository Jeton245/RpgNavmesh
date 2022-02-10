using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public string itemName = "Some Item";
    public Texture itemtexture;
    void Start()
    {
        gameObject.tag = "Respawn";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickItems()
    {
        Destroy(gameObject);
    }
}
