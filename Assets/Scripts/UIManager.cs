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
        UpdateScoreText(0);
        UpdateLivesText(3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateItemText(string item)
    {
        ItemText.text = "Item: " +item;


    }
    public void UpdateScoreText(int number)
    {
        ScoreText.text = "Score: " +number;
    }
    public void UpdateLivesText(int live)
    {
        LivesText.text = "Lives: " + live;

    }
}
