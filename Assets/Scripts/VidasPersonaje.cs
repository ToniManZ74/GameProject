using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class VidasPersonaje : MonoBehaviour
{
    public CameraVibration cameraVibration;
    public int lives = 3;
    public KeyCode oneVidaLessKey = KeyCode.Y;
    public KeyCode oneVidaUpKey = KeyCode.U;
    public int vidaMaxPersonaje = 7;
    public ItemsPj PowerUpActual;
    private GameObject gameOverPanel;




    void Start()
    {
        gameOverPanel = GameObject.FindGameObjectWithTag("GameOver");
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);  
        }
        Time.timeScale = 1;


    }
    void Update()
    {
        
        if (Input.GetKeyDown(oneVidaLessKey))
        {
            LoseLife(1);
        }

        if (Input.GetKeyDown(oneVidaUpKey))
        {
            LifeUp();
        }

        
    }

    public void LoseLife(int damage)
    {
       if (!PowerUpActual.isInvincible)
       {
            lives -= damage;
            Debug.Log("-1 de vida, te quedan: " + lives);

            if (lives <= 0)
            {
                lives = 0;
                Debug.Log("Game Over");
                ShowGameOverPanel();
                StartCoroutine(SlowDownTime());  

            }
            cameraVibration.StartVibration();
            UpdateLivesText();
        }
    }
    void LifeUp()
    {
        if (lives >= vidaMaxPersonaje)
        {
            Debug.Log("Tienes " + vidaMaxPersonaje + " de vida. No puedes tener mas");
        }
        else
        {
            lives++;
            Debug.Log("+1 de vida, te quedan: " + lives);
        }
        UpdateLivesText();
    }
    void UpdateLivesText()
    {
        GameObject textObject = GameObject.FindGameObjectWithTag("livesText");
        if (textObject != null)
        {
            Text livesText = textObject.GetComponent<Text>();
            if (livesText != null)
            {
                livesText.text = lives.ToString();
            }
        }
    }
    void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        else
        {
            Debug.LogError("Game Over panel reference is missing!");
        }
    }
    IEnumerator SlowDownTime()
    {
        float duration = 1.0f; 
        float startTime = Time.time;

        while (Time.time < startTime + duration)
        {
            Time.timeScale = Mathf.Lerp(1, 0, (Time.time - startTime) / duration);
            yield return null;
        }

        Time.timeScale = 0;  
    }
}
