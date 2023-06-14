using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [Header("����������� �����")]
    [SerializeField] private int _sceneID;

    [SerializeField] private Image _image;
    [SerializeField] private Text _text;

    private void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    private IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_sceneID);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;//��� ���������� ��������
            _image.fillAmount = progress;
            _text.text = string.Format("{0:0}%", progress * 100);//{0:0} - ����������
            yield return null;
        }

    }

}
