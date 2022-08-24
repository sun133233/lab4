using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int a = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = a++;
        Debug.Log(gameObject.name + i);
    }
}
