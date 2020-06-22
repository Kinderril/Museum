using UnityEngine;
using System.Collections;
using TMPro;

public class WindowHall : MonoBehaviour
{
    public TextMeshProUGUI TextField;
    private float _setTime;

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
        if (delta > 1f)
        {


            if (TextField.gameObject.activeSelf)
            {
                TextField.gameObject.SetActive(false);
            }
        }

    }
}
