using UnityEngine;
using UnityEngine.UI;

public class EatingTimer : MonoBehaviour
{
    private Image _eatingTimer;

    public float currentTime;
    public GameManager gameManager;
    public bool eatingValue;

    private void Start()
    {
        _eatingTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {
        eatingValue = false;
        currentTime += Time.deltaTime;
        if (currentTime >= gameManager.eatingTimer)
        {
            eatingValue = true;
            currentTime = 0;
        }
        _eatingTimer.fillAmount = currentTime / gameManager.eatingTimer;
    }
}