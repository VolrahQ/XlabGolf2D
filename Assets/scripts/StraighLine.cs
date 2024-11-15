using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StraighLine : MonoBehaviour
{
    public Image sourceimage;
    public float straigh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (straigh < 100)
        {
            straigh = (straigh + 3) * Time.deltaTime;
        }
        sourceimage.rectTransform.sizeDelta = new Vector2(100, straigh);
        if (straigh > 80)
        {
            sourceimage.color = Color.white;
        }
    }
}
