using UnityEngine;
using UnityEngine.UI;
public class SoundButtonImage : MonoBehaviour
{
    [SerializeField] private Sprite _onSoundimage;
    [SerializeField] private Sprite _offSoundImage;
    private bool _soundOn;

    private void Start()
    {
        _soundOn = true;
    }
    public void ChangeImage()
    {
        if (_soundOn == true)
        {
            GetComponent<Image>().sprite = _offSoundImage;
            _soundOn = false;
        }
        else if (_soundOn == false)
        {
            GetComponent<Image>().sprite = _onSoundimage;
            _soundOn = true;
        }
    }
}
