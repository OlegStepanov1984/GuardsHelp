using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScalingButton : MonoBehaviour
{
    [SerializeField] private LayoutElement layoutElement;
    [SerializeField] private RectTransform content;
    [SerializeField] private TMP_Text text;

    private bool needUpdate = false;
    private void LateUpdate() 
    {
        if (!needUpdate)
            return;
        layoutElement.minHeight = content.sizeDelta.y;
        needUpdate = false;
    }

    public void SetText(string txt) 
    {
        text.text = txt;
        needUpdate = true;
    }

}
