using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _clickSound;
    [SerializeField] private AudioSource _mainMenuSound;
    [SerializeField] private AudioSource _gameSound;
    [SerializeField] private AudioSource _warroirSound;
    [SerializeField] private AudioSource _peasantSound;
    [SerializeField] private AudioSource _rules;
    [SerializeField] private GameManager _gameManager;
    private bool _soundOn;
    private void Start()
    {
        _mainMenuSound.Play();
    }
    public void BackToMenu()
    {
        _clickSound.Play();
        _mainMenuSound.Play();
        _mainMenuSound.time = 0;
        _gameSound.Pause();
    }
    public void NewGameButton()
    {
        _clickSound.Play();
        _mainMenuSound.Pause();
        _gameSound.Play();
        _gameSound.time = 0;
    }
    public void PeasantButton()
    {
        _clickSound.Play();
        _peasantSound.Play();
    }
    public void WarriorButton()
    {
        _clickSound.Play();
        _warroirSound.Play();
    }
    public void RulesButton()
    {
        _clickSound.Play();
        _rules.Play();
        _mainMenuSound.Pause();
    }
    public void ReturnBotton()
    {
        _clickSound.Play();
        _mainMenuSound.Play();
        _rules.Pause();
        _rules.time = 0;
    }
    public void Click()
    {
        _clickSound.Play();
    }
    public void OnOffSounds()
    {

        if (_soundOn == true)
        {
            _clickSound.Stop();
            _peasantSound.Stop();
            _warroirSound.Stop();
            AudioListener.pause = false;
            _soundOn = false;
        }
        else if (_soundOn == false)
        {
            AudioListener.pause = true;
            _soundOn = true;
        }
    }



}
