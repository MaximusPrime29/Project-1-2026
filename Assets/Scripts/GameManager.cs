using UnityEngine;
//using UnityEngine.UIElements;
//using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using System;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // doign the addlistenr 
    public Button GTFButton;
    public Button PaperButton;
    public Button PMDButton;
    public Button ResidualButton;

    public List<WasteItem> WasteItems = new List<WasteItem>();
   // public List<WasteItem> WasteItemsAdj = new List<WasteItem>();
    public UIManager UIManager;

    //public string ChosenItem;
    private WasteItem ChosenItem;

    public int CurrentScore = 0;
    public int CurrentLives = 3;
    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //System.Console.WriteLine("test");
        SelectWasteItem();
        GTFButton.onClick.AddListener(Bin1);
        PaperButton.onClick.AddListener(Bin2);
        PMDButton.onClick.AddListener(Bin3);
        ResidualButton.onClick.AddListener(Bin4);
        UIManager.UpdateScoreText(0);
        UIManager.UpdateLivesText(3);

        
    }

    public void SelectWasteItem()
    {

        ChosenItem = null;
        int index = Random.Range(0, WasteItems.Count);

        ChosenItem = WasteItems[index];
        UIManager.UpdateItemText(ChosenItem.itemName);

        //Debug.Log(WasteItems.Count);
        ChosenItem = WasteItems[index];


    }
    void Bin1()
    {
        check(WasteType.GTF);
    }
    void Bin2()
    {
        check(WasteType.Paper);
    }
    void Bin3()
    {
        check(WasteType.PMD);
    }
    void Bin4()
    {
        check(WasteType.Residual);
    }

    public void check(WasteType selectedBin)
    {
        if(selectedBin==ChosenItem.type)
        {
            CurrentScore += 100;
            UIManager.UpdateScoreText(CurrentScore);
            WasteItems.Remove(ChosenItem);


            CheckList();
            if (WasteItems.Count > 0)
            {

                SelectWasteItem();

            }
            //SelectWasteItem();
            CheckList();
        }
        else
        {
            CurrentLives--;
            UIManager.UpdateLivesText(CurrentLives);
            WasteItems.Remove(ChosenItem);
            CheckLives();
            SelectWasteItem();
        }

    }

    

   
    void Update()
    {

    }
    public void Won()
    {
        Debug.Log("You have won");
    }
    public void CheckList()
    {
        if(WasteItems.Count==0)
        {
            SceneManager.LoadScene("WinScene");

        
        }


    }
    public void CheckLives()
    {
        if(CurrentLives==0)
        {

            //load gameover scene
            SceneManager.LoadScene("LoseScene");

        }
        
    }
        









}
