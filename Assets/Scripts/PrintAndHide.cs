using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{   
    int i = 0;
    int blueNum;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        blueNum = Random.Range(200,250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + i);
        i++;

        if(i == 100)
        {
            GameObject.FindWithTag("Red").SetActive(false);
        } else if (i == blueNum)
        {
            GameObject.FindWithTag("Blue").GetComponent<Renderer>().enabled = false;
        }

    }
}
