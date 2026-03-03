using UnityEngine;
//using UnityEngine.UIElements;
//using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using System;
using TMPro;

public class GameManager : MonoBehaviour
{

    // doign the addlistenr 
    public Button GTFButton;
    public Button PaperButton;
    public Button PMDButton;
    public Button ResidualButton;

    public List<WasteItem> WasteItems = new List<WasteItem>();
    public UIManager UIManager;

    //public string ChosenItem;
    private WasteItem ChosenItem;
    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //System.Console.WriteLine("test");
        SelectWasteItem();
        GTFButton.onClick.AddListener(Bin1);
        PaperButton.onClick.AddListener(Bin2);
        PMDButton.onClick.AddListener(Bin3);
        ResidualButton.onClick.AddListener(Bin4);

        
    }
    void Bin1()
    {


    }
    void Bin2()
    {

    }
    void Bin3()
    {

    }
    void Bin4()
    {

    }

    public void check(WasteType selectedBin)
    {
        if(selectedBin==ChosenItem.type)
        { 
            UIManager.UpdateScoreText(100);
        }
        else
        {
            UIManager.UpdateLivesText(1);
        }

    }

    public static void buttonmethod()
    {

    }

    public void SelectWasteItem()
    {
        ChosenItem = null;
        int index = Random.Range(0, WasteItems.Count);

        ChosenItem = WasteItems[index];

        Debug.Log(ChosenItem);
        //ChosenItem =randomItem.itemName;
        
        
        //randomItem.itemName = ChosenItem;
        UIManager.UpdateItemText(ChosenItem.itemName);


    }
    void Update()
    {

    }





}
