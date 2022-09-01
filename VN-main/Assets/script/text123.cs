using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text123 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset textFile;
    string[] line = new string[8];
    string[] names = { "eiei","Fasai"};
    public Text textDisplay;
    int currentline = 0;
    void Start()
    {
        string allText = textFile.text;
        line = allText.Split("\n");
        displayText();
        //textDisplay = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentline++;
            displayText();
        }
    }
    void displayText()
    {
        string[] tmp = new string[2];
        tmp = line[currentline].Split(":");
        int cNumber = int.Parse(tmp[0]);
        string txt = "";
        if (cNumber > 0) txt = names[cNumber] + ":" + tmp[1];
        else txt = tmp[1];
        textDisplay.text = txt;
    }
}
