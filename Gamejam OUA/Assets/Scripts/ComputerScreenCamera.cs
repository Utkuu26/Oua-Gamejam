using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerScreenCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera computerCamera;
    public Vector3 targetPosition = new Vector3(12.15f, 4f, 2.11f);
    public float moveSpeed = 0.7f;
    public GameObject canvasObject;
    public AudioSource computerSfx;
    public AudioSource btnClickSfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SwitchCamObject")
        {
            computerCamera.gameObject.SetActive(true);
            mainCamera.gameObject.SetActive(false);
            computerSfx.Play();
        }
    }

    void Update()
    {
        if (computerCamera.enabled && Input.GetKeyDown(KeyCode.Escape))
        {
            computerCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
            mainCamera.transform.position = new Vector3(10f, 5.5f, 0f);
            mainCamera.transform.rotation = Quaternion.Euler(0f, -95f, 0f);
            canvasObject.SetActive(false);
        }

        float step = moveSpeed * Time.deltaTime;
        computerCamera.transform.position = Vector3.MoveTowards(computerCamera.transform.position, targetPosition, step);

        if (computerCamera.transform.position == targetPosition)
        {
            canvasObject.SetActive(true);
        }
    }

    public void LoadSceneRyhtm()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadSceneHyperCasual()
    {
        SceneManager.LoadScene(2);
    }


}
