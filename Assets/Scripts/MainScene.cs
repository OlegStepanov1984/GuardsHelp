using UnityEngine;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject firstPage;
    [SerializeField] private GameObject secondPage;
    [SerializeField] private GameObject thirdPage;

    private void Start() 
    {
        ShowStartPage();
    }
    public void ShowStartPage() 
    {
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
    }

    public void ShowSecondPage(int num) 
    {
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        thirdPage.SetActive(false);
    }

    public void ShowThirdPage(int num1, int num2)
    {
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(true);
    }
}
