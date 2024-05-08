using UnityEngine;
using UnityEngine.UI;

public class VidasPersonaje : MonoBehaviour
{
    public CameraVibration cameraVibration;
    public int lives = 3;
    public KeyCode oneVidaLessKey = KeyCode.Y;
    public KeyCode oneVidaUpKey = KeyCode.U;


    void Update()
    {
        if (Input.GetKeyDown(oneVidaLessKey))
        {
            LoseLife();
            cameraVibration.StartVibration();
        }

        if (Input.GetKeyDown(oneVidaUpKey))
        {
            LifeUp();
        }
        
    }

    void LoseLife()
    {
        lives--;
        Debug.Log("-1 de vida, te quedan: " + lives);

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
        UpdateLivesText();
    }
    void LifeUp()
    {
        if (lives >= 5)
        {
            Debug.Log("Tienes 5 de vida. No puedes tener mas");
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
}
