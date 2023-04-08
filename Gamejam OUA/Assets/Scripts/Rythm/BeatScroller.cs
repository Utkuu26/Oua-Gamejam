using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public List<RectTransform> arrowImages; 

    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
            else
            {
                foreach (RectTransform arrowImage in arrowImages)
                {
                    arrowImage.anchoredPosition -= new Vector2(0f, beatTempo * Time.deltaTime * 10f);
                }
            }
        }
    }
}
