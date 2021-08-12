using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceTexts : MonoBehaviour
{
    [Header("Texts")]
    public TextMeshProUGUI ViciText;
    public TextMeshProUGUI CiviliansText;
    public TextMeshProUGUI BarracksText;
    public TextMeshProUGUI ArmyText;
    public TextMeshProUGUI SatisfactionText;

    private static int ViciNum;
    private static int CivilianNum;
    private static int BarrackNum;
    private static int ArmyNum;
    private static int SatisfactionNum;

    // Start is called before the first frame update
    void Start()
    {
        ViciNum = 0;
        CivilianNum = 10;
        BarrackNum = 0;
        ArmyNum = 80;
        SatisfactionNum = 10;
    }

    // Update is called once per frame
    void Update()
    {
        ViciText.text = $"Vici : {ViciNum}";
        CiviliansText.text = $"Civilians : {CivilianNum}";
        BarracksText.text = $"Barracks : {BarrackNum} / 8";
        ArmyText.text = $"Army : {ArmyNum}";
        SatisfactionText.text = $"Satisfaction : {SatisfactionNum}%";
    }

    public static void BuildAVicus()
    {
        ViciNum += 1;
        CivilianNum += 5;
    }

    public static void BuildABarrack()
    {
        BarrackNum += 1;
        if (ArmyNum == 80) { }
        else
            ArmyNum += 80;
    }

    public static void SatisfactionIncrease(int a)
    {
        if (SatisfactionNum <= 100)
            SatisfactionNum += a;
    }
}
