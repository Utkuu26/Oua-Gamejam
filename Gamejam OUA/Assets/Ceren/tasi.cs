using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tasi : MonoBehaviour
{
    Camera kamera;
    new Vector3 baslangic_pozisyonu;
    GameObject[] kutu_dizisi;
    yonetici yonet;


    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pozisyonu = transform.position;

        kutu_dizisi = GameObject.FindGameObjectsWithTag("kutu");
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();

    }

    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {

            foreach (GameObject kutu in kutu_dizisi)
            {
                if (kutu.name  == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);
                    {
                        if (mesafe <= 1)
                        {
                            transform.position = kutu.transform.position;
                            yonet.sayi_arttir();
                            this.enabled = false;
                        }
                        else
                        {
                            transform.position = baslangic_pozisyonu;
                        }
                    }
                }

            }

        }
    }
}











