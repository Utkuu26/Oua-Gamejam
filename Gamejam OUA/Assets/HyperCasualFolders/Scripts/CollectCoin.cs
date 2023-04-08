using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    public PlayerController PlayerController;

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
        CoinText.text = "Score: " + score.ToString();
    }
}
