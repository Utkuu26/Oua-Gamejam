using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeniGorsel : MonoBehaviour
{
    private Vector3 baslangicPozisyonu;
    private bool dogruYerdeMi = false;

    void Start()
    {
        // Resmin başlangıç pozisyonunu kaydedin
        baslangicPozisyonu = transform.position;
    }

    void OnMouseDrag()
    {
        // Resmi sürüklemek için fare pozisyonunu dünya koordinatlarına çevirin
        Vector3 pozisyon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    void OnMouseUp()
    {
        // Resim kutuyla temas ederse
        if (dogruYerdeMi == false)
        {
            Collider[] temasEdenColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);

            foreach (Collider temasEdenCollider in temasEdenColliders)
            {
                // Eğer temas eden collider bir kutuysa
                if (temasEdenCollider.CompareTag("kutu"))
                {
                    // Eğer resmin adı kutunun adıyla aynıysa doğru yerde demektir
                    if (temasEdenCollider.name == name)
                    {
                        transform.position = temasEdenCollider.transform.position;
                        dogruYerdeMi = true;
                    }
                    // Eğer resim yanlış kutuda ise eski pozisyonuna geri döndürün
                    else
                    {
                        transform.position = baslangicPozisyonu;
                    }

                    break;
                }
            }
        }
    }
}
