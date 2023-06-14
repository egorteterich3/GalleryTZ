using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class DownloadingImages : MonoBehaviour
{

    [SerializeField] private View _view;
    [SerializeField] private string _url;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();

        StartCoroutine(LoadImage());
    }

    public void OnButtonClick()
    {
        _view.gameObject.SetActive(true);
        _view._imageSprite.sprite = _image.sprite;
    }

    public IEnumerator LoadImage()
    {
        UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(_url);

        yield return webRequest.SendWebRequest();

        if(webRequest.isDone == false)
        {
            Debug.Log(webRequest.error);
        }
        else
        {
            Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;

            _image.sprite = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }
    }
}
