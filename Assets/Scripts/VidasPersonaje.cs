using UnityEngine;
using UnityEngine.UI;

public class VidasPersonaje : MonoBehaviour
{
    public CameraVibration cameraVibration;
    public int lives = 3;
    public KeyCode oneVidaLessKey = KeyCode.Y;
    public KeyCode oneVidaUpKey = KeyCode.U;
    public int vidaMaxPersonaje = 7;
    public ItemsPj PowerUpActual;
    private AudioSource audio;
    public AudioClip sound;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
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
                Debug.Log("Game Over");
                Time.timeScale = 0f;
            }
            audio.PlayOneShot(sound);
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
}
