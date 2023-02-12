using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseGameScreen;
    [SerializeField] private GameObject _rulesScreen;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private GameObject _mainMenuScreen;
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _vinScreen;
    [SerializeField] private int _wheatToEating;
    [SerializeField] private int _wheatPerPeasant;
    [SerializeField] private Text _countText;
    [SerializeField] private Text _enemyCount;
    [SerializeField] private Text _raidCounter;

    public Button peasantButton;
    public Button warriorButton;
    public RaidTimer raidTime;
    public HarvestTimer harvestTime;
    public EatingTimer eatingTime;
    public PeasantCreateTimer peasantCreateTimer;
    public WarriorCreateTimer warriorCreateTimer;

    public int wheatCount;
    public int warriosCount;
    public int enemyWarroirsCount;
    public int peasantCount;
    public int peasantCost;
    public int warriorCost;

    public float peasantCreateTime;
    public float warriorCreateTime;
    public float harvestTimer;
    public float eatingTimer;
    public float raidTimer;



    private void Start()
    {
        _mainMenuScreen.SetActive(true);
        _gameScreen.SetActive(false);
        _gameOverScreen.SetActive(false);
        _pauseGameScreen.SetActive(false);
        _rulesScreen.SetActive(false);
        _vinScreen.SetActive(false);
        ResoursesCountText();
    }
    private void Update()
    {

        if (harvestTime.harvestValue == true)
        {
            wheatCount += peasantCount * _wheatPerPeasant;
        }
        if (eatingTime.eatingValue == true)
        {
            wheatCount -= warriosCount * _wheatToEating;
        }
        ResoursesCountText();
        EnemyCountText();
        RaidCountCounter();
        RaidEnemyNull();
        if (warriosCount < 0)
        {
            _gameScreen.SetActive(false);
            _gameOverScreen.SetActive(true);
        }
        if (raidTime.raidCount > 14)
        {
            if(warriosCount >= 0)
            {
                _gameScreen.SetActive(false);
                _vinScreen.SetActive(true);
            }
        }
        if(wheatCount <= 0)
        {
            wheatCount =0;
        }
}
    private void ResoursesCountText()
    {
        _countText.text = wheatCount + "\n" + warriosCount + "\n" + peasantCount;
    }

    private void EnemyCountText()
    {
        _enemyCount.text = raidTime.nextRaidEnemyCount.ToString();
    }

    private void RaidCountCounter()
    {
        _raidCounter.text = raidTime.raidCount.ToString();
    }

    private void RaidEnemyNull()
    {
        if(raidTime.raidCount == 0)
        {
            _enemyCount.text = 0.ToString();
        }
    }

    public void ExitToGame()
    {
        Application.Quit();
    }

}

