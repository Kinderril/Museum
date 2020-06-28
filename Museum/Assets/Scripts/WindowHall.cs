using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class WindowHall : MonoBehaviour
{
    public TextMeshProUGUI TextField;
//    public TextMeshProUGUI ContainerField;
    public RawImage Img;
    public GameObject Container;
    private float _setTime;
    private bool _isBigOpen;

    void Awake()
    {
        Close();
    }

    public void SetInfo(string objInfo)
    {


        if (!TextField.gameObject.activeSelf)
        {
            TextField.gameObject.SetActive(true);
            TextField.text = objInfo;
            _setTime = Time.time;
        }
    }

    public void SetNull()
    {
        var delta = Time.time - _setTime;
        if (delta > 1f && !_isBigOpen)
        {


            if (TextField.gameObject.activeSelf)
            {
                TextField.gameObject.SetActive(false);
            }
        }

    }

    void Update()
    {
        if (_isBigOpen)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Close();
            }

            if (Input.GetMouseButtonDown(1))
            {
                Close();
            }
        }
    }

    public void Close()
    {
        _isBigOpen = false;
        Container.gameObject.SetActive(_isBigOpen);
    }

    public void ShowBigInfo(PictureObject pictureObject)
    {
        if (_isBigOpen)
        {
            return;
        }

//        ContainerField.text = pictureObject.Info;
        _isBigOpen = true;
        Container.gameObject.SetActive(_isBigOpen);
        Img.texture = pictureObject.Texture;
        var w = Screen.width - 100;

        var p = (float)pictureObject.Texture.height / (float)pictureObject.Texture.width;
//        var sizeOld = Img.rectTransform.rect;

        var h = p * w;
        if (h > Screen.height)
        {
            h = Screen.height - 100;
            w = (int)(h / p);

        }

        var size = new Vector2(w, h);
        
        Img.rectTransform.sizeDelta= size;
    }
}
