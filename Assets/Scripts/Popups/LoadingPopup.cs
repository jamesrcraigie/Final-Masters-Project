using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPopup : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
