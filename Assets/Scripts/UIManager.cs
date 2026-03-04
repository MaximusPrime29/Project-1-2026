using JetBrains.Annotations;
using System.Net.NetworkInformation;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI ItemText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI LivesText;
    //public int StartLife = 3;
    //public int StartScore = 0;
    //public int CurrentScore = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InitiateScore(0);
       // InitiateLives(3);
        
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
        // CurrentScore = StartScore + number +CurrentScore;
        
        ScoreText.text = "Score: " +number;
    }
    public void UpdateLivesText(int live)
    {

        LivesText.text = "Lives: " + live;

    }
    

}
