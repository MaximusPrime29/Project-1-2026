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

    public Button GTFButton;
    public Button PaperButton;
    public Button PMDButton;
    public Button ResidualButton;

    public List<WasteItem> WasteItems = new List<WasteItem>();

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //System.Console.WriteLine("test");
        SelectWasteItem();
        
    }
    public static void buttonmethod()
    {

    }

    public void SelectWasteItem()
    {
        int index = Random.Range(0, WasteItems.Count);

        WasteItem randomItem = WasteItems[index];

        Debug.Log(randomItem);


    }
    void Update()
    {

    }





}
