using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour
{
    public WindowHall Hall;

    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out var hitInfo, 3))
        {
            var obj = hitInfo.transform.GetComponent<PictureObject>();
            if (obj != null)
            {
                Hall.SetInfo(obj.Info);
            }
            else
            {
                Hall.SetNull();
            }
        }
        else
        {
            Hall.SetNull();
        }


    }
}
