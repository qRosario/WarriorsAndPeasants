using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private Sprite _onGameimage;
    [SerializeField] private Sprite _offGameImage;
    private bool _gameOn;
    private bool _pause;

    public EatingTimer eatingTimer;
    public RaidTimer raidTimer;
    public HarvestTimer harvestTimer;
    public WarriorCreateTimer warriorCreateTimer;
    public PeasantCreateTimer peasantCreateTimer;
    public GameManager gameManager;

    private void Start()
    {
        _gameOn = true;
    }
    public void ChangeImage()
    {
        if (_gameOn == true)
        {
            GetComponent<Image>().sprite = _offGameImage;
            _gameOn = false;
        }
        else if (_gameOn == false)
        {
            GetComponent<Image>().sprite = _onGameimage;
            _gameOn = true;
        }
    }
    public void GamePause()
    {
        if(_pause == true)
        {
            Time.timeScale = 1;
            _pause = false;
        }
        else if(_pause == false)
        {
            Time.timeScale = 0;
            _pause = true;
        }
    }
    public void RestartGame()
    {
        eatingTimer.currentTime = 0;
        raidTimer.currentTime = 0;
        harvestTimer.currentTime = 0;
        warriorCreateTimer.currentTime = 0;
        peasantCreateTimer.currentTime = 0;
        gameManager.peasantCount = 5;
        gameManager.warriosCount = 1;
        gameManager.wheatCount = 40;
        raidTimer.raidCount = 0;
        gameManager.enemyWarroirsCount = 0;
        raidTimer.nextRaidEnemyCount = 0;
    }
}