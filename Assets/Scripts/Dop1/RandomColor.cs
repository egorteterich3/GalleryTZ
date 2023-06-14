using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public void ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.TryGetComponent(out Rotate rotate))
            {
                ChangeColor();
            }
        }
    }

}
