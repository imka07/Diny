using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmoothEnabler : MonoBehaviour
{
    [SerializeField] private float _fadeDuration = 1;
    [SerializeField] private Button _button;

    void Start()
    {
        StartCoroutine(SmoothEnable());
    }

    private IEnumerator SmoothEnable()
    {
        _button.interactable = false;
        //while (true)
        //{
        //    Run();
        //    yield return new WaitForSeconds(2);
        //    Shoot();
        //}
        var newColor = _button.image.color;
        var maxDuration = _fadeDuration;
        while (_fadeDuration > 0)
        {
            _fadeDuration -= Time.unscaledDeltaTime;
            newColor.a = 1 - _fadeDuration / maxDuration;
            _button.image.color = newColor;
            yield return null;
        }
        _button.interactable = true;
    }
}
