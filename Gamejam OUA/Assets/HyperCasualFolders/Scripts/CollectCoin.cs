using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    public PlayerController PlayerController;
    public Slider görevDurumu;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
            
        }
        else if (other.CompareTag("End"))
        {
            Debug.Log("congrats");
            PlayerController.runningSpeed = 0;

            if (score > 5)
            {
                Debug.Log("you win");
            }
            else
            {

                Debug.Log("You lose");
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collison"))
        {
            Debug.Log("Deðdi");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void AddCoin()
    {
        score++;
        CoinText.text = "Aylýk Görev:" + "%" + score.ToString();
        görevDurumu.value += 2f;
        Debug.Log(görevDurumu.value);

    }
}
