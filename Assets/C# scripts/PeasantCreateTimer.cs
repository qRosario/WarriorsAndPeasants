using UnityEngine;
using UnityEngine.UI;

public class PeasantCreateTimer : MonoBehaviour
{
    private Image _peasantCreateTimer;

    public float currentTime;
    public GameManager gameManager;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _peasantCreateTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {
        
        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
            _peasantCreateTimer.fillAmount = 0 + currentTime / gameManager.peasantCreateTime;
        }
        if (currentTime >= gameManager.peasantCreateTime)
        {
            timerActive = false;
            currentTime = 0;
            _peasantCreateTimer.fillAmount = 1;
            gameManager.peasantButton.interactable = true;
            gameManager.peasantCount += 1;
        }
        if (gameManager.wheatCount < gameManager.peasantCost)
        {
            gameManager.peasantButton.interactable = false;
        }
        if(timerActive == false)
        {
            if (gameManager.wheatCount > gameManager.peasantCost)
            {
                gameManager.peasantButton.interactable = true;
            }
        }

    }
    public void CreatePeasant()
    {
        timerActive = true;
        gameManager.wheatCount -= gameManager.peasantCost;
        gameManager.peasantButton.interactable = false;

    }
}
