using UnityEngine;
using UnityEngine.UI;

public class RaidTimer : MonoBehaviour
{
    private Image _raidTimer;

    public int raidCount;
    public int nextRaidEnemyCount;
    public float currentTime;
    public GameManager gameManager;
    public bool raidvalue;


    private void Start()
    {
        _raidTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {
        raidvalue = false;
        currentTime += Time.deltaTime;
        if (currentTime >= gameManager.raidTimer)
        {
            raidvalue = true;
            currentTime = 0;
        }
        _raidTimer.fillAmount = currentTime / gameManager.raidTimer;
        if (raidvalue == true)
        {
            raidCount++;
            if (raidCount > 3)
            {
                gameManager.enemyWarroirsCount++;
                gameManager.warriosCount -= gameManager.enemyWarroirsCount;
                nextRaidEnemyCount = gameManager.enemyWarroirsCount + 1;
            }
            if (raidCount == 3)
            {
                nextRaidEnemyCount = 1;
            }
        }
    }
}
