using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI ItemText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI LivesText;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateItemText(string item)
    {
        ItemText.text = "Item: " +item;


    }
    public void UpdateScoreText(string text)
    {
        ScoreText.text = text;
    }
    public void UpdateLivesText()
    {

    }
}
