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
    public Slider g�revDurumu;
    public Animator PlayerAnim;
    public GameObject Player;
    public Transform _playerTransform;

    private void Start()
    {
        PlayerAnim = Player.GetComponentInChildren<Animator>();
        
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
            
            PlayerController.runningSpeed = 0;
            transform.Rotate(transform.rotation.x, 180, transform.rotation.z);

            if (g�revDurumu.value == 100)
            {
                Debug.Log("you win");
                PlayerAnim.SetBool("win", true);
                
                
            }
            else
            {

                Debug.Log("You lose");
                PlayerAnim.SetBool("lose", true);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collison"))
        {
            Debug.Log("De�di");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void AddCoin()
    {
        score++;
        CoinText.text = "Ayl�k G�rev:" + "%" + score.ToString();
        g�revDurumu.value += 2f;
        Debug.Log(g�revDurumu.value);

    }
}
