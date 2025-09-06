using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject firstPage;
    [SerializeField] private GameObject secondPage;
    [SerializeField] private GameObject thirdPage;
    [SerializeField] private GameObject backButton;
    [SerializeField] private ScalingButton scalingButton1;
    [SerializeField] private ScalingButton scalingButton2;

    [SerializeField] private ScrollRect itemsScrollRect;
    [SerializeField] private RectTransform item1;
    [SerializeField] private RectTransform item2;

    private int pageNum;
    private int groupInex;
    private int itemIndex;

    private void Start() 
    {
        ShowStartPage();
    }
    public void ShowStartPage() 
    {
        pageNum = 1;
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        backButton.SetActive(false);
    }

    public void ShowSecondPage(int num) 
    {
        pageNum = 2;
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        thirdPage.SetActive(false);
        backButton.SetActive(true);
        groupInex = num;

        scalingButton1.SetText("Противодействие пролёту, облёту, причинению вреда охраняемому объекту БПЛА.");
        scalingButton2.SetText("Действия при захвате заложников.");
    }

    public void ShowThirdPage(int num)
    {
        pageNum = 3;
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(true);
        backButton.SetActive(true);
        itemIndex = num;

        itemsScrollRect.content.gameObject.SetActive(false);

        itemsScrollRect.content = num == 0 ? item1 : item2;
        var pos = itemsScrollRect.content.anchoredPosition;
        pos.y = 0;
        itemsScrollRect.content.anchoredPosition = pos;
        itemsScrollRect.content.gameObject.SetActive(true);
    }

    public void Back() 
    {
        if (pageNum == 3)
            ShowSecondPage(groupInex);
        else if (pageNum == 2)
            ShowStartPage();
    }
}
