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
    public TextMeshProUGUI UnityText;
    public TextMeshProUGUI GirisimcilikText;
    public TextMeshProUGUI ProjeText;
    public TextMeshProUGUI EnglishText;
    public PlayerController PlayerController;
    public Slider g�revDurumu;
    public Animator PlayerAnim;
    public GameObject Player;
    public Transform _playerTransform;
    public AudioSource winMusic;
    public AudioSource coinSound;

    private void Start()
    {
        PlayerAnim = Player.GetComponentInChildren<Animator>();
        winMusic = GetComponent<AudioSource>();
        coinSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
            other.GetComponent<AudioSource>().Play();
            
        }
        else if (other.CompareTag("End"))
        {
            
            PlayerController.runningSpeed = 0;
            transform.Rotate(transform.rotation.x, 180, transform.rotation.z);
            

            if (g�revDurumu.value <= 100)
            {
                Debug.Log("you win");
                PlayerAnim.SetBool("win", true);

                
                UnityText.text = "Unity G�revleri: " + "Tamamlandi";
                UnityText.color = Color.green;
                GirisimcilikText.text = "Girisimcilik Egitimleri: " + "Tamamlandi";
                GirisimcilikText.color = Color.green;
                ProjeText.text = "Proje Y�netimi: " + "Tamamlandi";
                ProjeText.color = Color.green;
                EnglishText.text = "Ingilizce Egitimleri: " + "Tamamlandi";
                EnglishText.color = Color.green;
                winMusic.Play();


            }
            else
            {
                
                Debug.Log("You lose");
                PlayerAnim.SetBool("lose", true);
                UnityText.text = "Unity G�revleri: " + "Tamamlandi";
                UnityText.color = Color.green;
                GirisimcilikText.text = "Girisimcilik Egitimleri: " + "Tamamlanmadi";
                GirisimcilikText.color = Color.red;
                ProjeText.text = "Proje Y�netimi: " + "Tamamlanmadi";
                ProjeText.color = Color.red;
                EnglishText.text = "Ingilizce Egitimleri: " + "Tamamlandi";
                EnglishText.color = Color.green;
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
        if (score <100)
        {
            score++;
        }
        
        CoinText.text = "Ayl�k G�rev:" + "%" + score.ToString();
        g�revDurumu.value = score;
        Debug.Log(g�revDurumu.value);

    }
    

}
