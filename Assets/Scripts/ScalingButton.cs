using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScalingButton : MonoBehaviour
{
    [SerializeField] private LayoutElement layoutElement;
    [SerializeField] private RectTransform content;
    [SerializeField] private TMP_Text text;

    
    public void SetText(string txt) 
    {
        text.text = txt;
        StartCoroutine(UpdateHeight());
    }

    private IEnumerator UpdateHeight() 
    {
        yield return new WaitForEndOfFrame();
        layoutElement.minHeight = content.sizeDelta.y;
    }

}
