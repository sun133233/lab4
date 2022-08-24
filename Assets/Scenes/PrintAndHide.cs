using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    public int randomInteger;


    // Start is called before the first frame update
    void Start()
    {
        randomInteger = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        int b = ++i;
        Debug.Log(gameObject.name +":" + b);
        if (gameObject.CompareTag("Red") && b == 100)
            gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && b == randomInteger)
            rend.enabled = false;
    }
}
