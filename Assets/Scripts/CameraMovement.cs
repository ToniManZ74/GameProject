using UnityEngine;

public class CameraVibration : MonoBehaviour
{
    public KeyCode vibrationKey = KeyCode.G;
    public float vibrationIntensity = 0.1f;
    public float vibrationDuration = 0.1f;
    public float vibrationSpeed = 10f;

    private bool isVibrating = false;
    private Vector3 originalPosition;
    private float vibrationTimer = 0f;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(vibrationKey) && !isVibrating)
        {
            StartVibration();
        }

        if (isVibrating)
        {
            float offsetY = Mathf.Sin(Time.time * vibrationSpeed) * vibrationIntensity;
            transform.position = originalPosition + new Vector3(0f, offsetY, 0f); 

            vibrationTimer += Time.deltaTime;

            if (vibrationTimer >= vibrationDuration)
            {
                StopVibration();
            }
        }
    }

    void StartVibration()
    {
        vibrationTimer = 0f;
        isVibrating = true;
    }

    void StopVibration()
    {
        transform.position = originalPosition;
        isVibrating = false;
    }
}
