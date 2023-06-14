using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class View : MonoBehaviour
{

    public Image _imageSprite;

    private void Start()
    {
        _imageSprite = GetComponent<Image>();
    }

    public void ClickBackImage()
    {
        _imageSprite.gameObject.SetActive(false);
    }

}
