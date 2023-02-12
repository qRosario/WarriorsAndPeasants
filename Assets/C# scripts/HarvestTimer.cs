using UnityEngine;
using UnityEngine.UI;

public class HarvestTimer : MonoBehaviour
{
    private Image _harvestTimer;

    public float currentTime;
    public GameManager gameManager;
    public bool harvestValue;


    private void Start()
    {
        _harvestTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {
        harvestValue = false;
        currentTime += Time.deltaTime;
        if (currentTime >= gameManager.harvestTimer)
        {
            harvestValue = true;
            currentTime = 0;
        }
        _harvestTimer.fillAmount = currentTime / gameManager.harvestTimer;
    }
}
