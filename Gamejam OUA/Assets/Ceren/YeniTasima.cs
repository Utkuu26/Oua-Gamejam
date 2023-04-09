using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeniTasima : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic_pozisyonu;

    GameObject[] kututag_dizisi;
    yonetici yonet;

    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;

        Vector3 dogru_konum = Vector3.zero;
        bool dogru_konum_bulundu = false;

        foreach (GameObject kututag in kututag_dizisi)
        {
            float mesafe = Vector3.Distance(kututag.transform.position, transform.position);

            if (mesafe <= 1)
            {
                dogru_konum = kututag.transform.position;
                dogru_konum_bulundu = true;
                break;
            }
        }

        if (dogru_konum_bulundu)
        {
            transform.position = dogru_konum;
            yonet.sayi_arttir();
            this.enabled = false;
        }
        else
        {
            transform.position = pozisyon;
        }
    }

    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pozisyonu = transform.position;

        kututag_dizisi = GameObject.FindGameObjectsWithTag("kututag");
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }
}
