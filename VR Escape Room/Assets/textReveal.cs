using System.Collections;
using TMPro;
using UnityEngine;
using System.Collections.Generic;
public class textReveal : MonoBehaviour
{
    TextMeshPro _textMesh;
    string[] _textCharacter;
    public bool _isActive= true;
    public float _timeInSeconds;
    private float _timer;
    int _charCount;

    private void Start()
    {
        _textMesh = GetComponent<TextMeshPro>();
        _textCharacter = new string[_textMesh.text.Length];

        for(int i=0; i< _textMesh.text.Length; i++)
        {
            _textCharacter[i] = _textMesh.text.Substring(i, 1);
        }
        _textMesh.text = " ";
        _charCount = 0;
        _timer = 0;
    }

    void Update()
    {
        _isActive = true;
        if(_isActive)
        {
            if(_charCount < _textCharacter.Length)
                {
                _timer += Time.deltaTime;
                if(_timer >= _timeInSeconds)
                {
                    _textMesh.text += _textCharacter[_charCount];
                    _charCount++;
                    _timer = 0;
                }
                }
            if(_charCount == _textCharacter.Length)
            {
                if(transform.childCount > 0)
                {
                    transform.GetChild(0).GetComponent<textReveal>()._isActive = true;
                    _charCount++;
                }
            }
        }
    }
}