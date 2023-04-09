using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public List<RectTransform> arrowImages; 
    public AudioSource[] audioSources;
    private int currentIndex = 0;
    

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
        }
    
        foreach (RectTransform arrowImage in arrowImages)
        {
            arrowImage.anchoredPosition -= new Vector2(0f, beatTempo * Time.deltaTime * 150f);
        }
    }

    public void PlayNextSound()
{
    if(currentIndex < audioSources.Length)
    {
        // Mevcut index'deki ses durdurulur.
        if (currentIndex > 0)
        {
            audioSources[currentIndex - 1].Stop();
        }
        
        // Sonraki sıradaki ses çalınır ve takip edilen index arttırılır.
        audioSources[currentIndex].Play();
        currentIndex++;
    }

    // Index son sese ulaştıysa, son sese ulaşıldı mesajı verilir.
    if(currentIndex == audioSources.Length)
    {
        Debug.Log("Son sese ulaşıldı.");
    }
}
}
