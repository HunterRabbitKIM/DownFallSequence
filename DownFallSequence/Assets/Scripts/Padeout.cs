using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Padeout : MonoBehaviour
{
    private Image image;
    private bool coloron = true;

    private void OnEnable()
    {
        coloron = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = image.color;
        if (coloron)
        {
            if (color.a >= 1)
            {
                coloron = false;

            }
            else if (color.a < 1)
            {
                color.a = 1;
            }
            image.color = color;
        }
        else if (!coloron)
        {
            if (color.a > 0)
            {
                color.a -= Time.deltaTime;
            }

            image.color = color;
        }



    }

}
