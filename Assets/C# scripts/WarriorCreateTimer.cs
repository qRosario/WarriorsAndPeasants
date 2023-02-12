using UnityEngine;
using UnityEngine.UI;

public class WarriorCreateTimer : MonoBehaviour
{
    private Image _warriorCreateTimer;

    public float currentTime;
    public GameManager gameManager;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _warriorCreateTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {

        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
            _warriorCreateTimer.fillAmount = 0 + currentTime / gameManager.warriorCreateTime;
        }
        if (currentTime >= gameManager.warriorCreateTime)
        {
            timerActive = false;
            currentTime = 0;
            _warriorCreateTimer.fillAmount = 1;
            gameManager.warriorButton.interactable = true;
            gameManager.warriosCount += 1;
        }
        if(gameManager.wheatCount < gameManager.warriorCost)
        {
            gameManager.warriorButton.interactable = false;
        }
        if (timerActive == false)
        {
            if (gameManager.wheatCount > gameManager.warriorCost)
            {
                gameManager.warriorButton.interactable = true;
            }
        }

    }
    public void CreateWarrior()
    {
        timerActive = true;
        gameManager.wheatCount -= gameManager.warriorCost;
        gameManager.warriorButton.interactable = false;
    }
}
