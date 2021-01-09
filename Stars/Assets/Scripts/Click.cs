using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public int count;
    public Text textLayer;
    void Start()
    {
        count = 0;
        textLayer.text = count.ToString();

    }

    void Update()
    {
        textLayer.text = count.ToString();
    }

    public void Inc()
    {
        count++;
    }
}
