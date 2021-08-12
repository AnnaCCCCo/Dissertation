using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingButton : MonoBehaviour
{
    [Header("Presfabs")]
    public GameObject VicusPrefab;
    public GameObject WallPrefab;
    public GameObject TemplePrefab;
    public GameObject PraetoriumPrefab;
    public GameObject PrincipiaPrefab;
    public GameObject TavernPrefab;
    public GameObject BarrackPrefab;
    public GameObject HorreaPrefab;
    public GameObject BathHousePrefab;

    [Header("Texts of Num")]
    public TextMeshProUGUI WallNumText;
    public TextMeshProUGUI TempleNumText;
    public TextMeshProUGUI PraetoriumNumText;
    public TextMeshProUGUI PrincipiaNumText;
    public TextMeshProUGUI TavernNumText;
    public TextMeshProUGUI HorreaNumText;
    public TextMeshProUGUI BathHouseNumText;
    public TextMeshProUGUI BarrackNumText;

    [Header("Buttons")]
    public Button WallButton;
    public Button TempleButton;
    public Button PraetoriumButton;
    public Button PrincipiaButton;
    public Button TavernButton;
    public Button HorreaButton;
    public Button BathHouseButton;
    public Button BarrackButton;

    public static int WallNum;
    public static int TempleNum;
    public static int PraetoriumNum;
    public static int PrincipiaNum;
    public static int TavernNum;
    public static int HorreaNum;
    public static int BathHouseNum;
    public static int BarrackNum;

    private Vector3 InstPos;
    public GameObject Arrow;
    public static GameObject ArrowInst;

    void Update()
    {
        WallNumText.text = $"[{WallNum}/1]";
        TempleNumText.text = $"[{TempleNum}/1]";
        PraetoriumNumText.text = $"[{PraetoriumNum}/1]";
        PrincipiaNumText.text = $"[{PrincipiaNum}/1]";
        TavernNumText.text = $"[{TavernNum}/1]";
        HorreaNumText.text = $"[{HorreaNum}/2]";
        BathHouseNumText.text = $"[{BathHouseNum}/1]";
        BarrackNumText.text = $"[{BarrackNum}/8]";

        if (WallNum == 1)
            WallButton.interactable = false;
        if (TempleNum == 1)
            TempleButton.interactable = false;
        if (PraetoriumNum == 1)
            PraetoriumButton.interactable = false;
        if (PrincipiaNum == 1)
            PrincipiaButton.interactable = false;
        if (TavernNum == 1)
            TavernButton.interactable = false;
        if (HorreaNum == 2)
            HorreaButton.interactable = false;
        if (BathHouseNum == 1)
            BathHouseButton.interactable = false;
        if (BarrackNum == 8)
            BarrackButton.interactable = false;

        InstPos = new Vector3(Camera.main.transform.position.x, 1, Camera.main.transform.position.z + 10.5f);
    }

    public void BuildAVicus()
    {
        Base.built = false;
        GameObject instance = (GameObject)Instantiate(VicusPrefab, InstPos, new Quaternion(0, 0, 0, 0));
    }

    public void BuildWalls()
    {
        //instantiate wall's prefab
        Base.built = false;
        _ = (GameObject)Instantiate(WallPrefab, InstPos, new Quaternion(0, 0, 0, 0));

        //instantiate arrow right above wall's bases
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(13.46f, 2.5f, 2.93f), new Quaternion(0, 0, 0, 0));

        //Turn wall's bases into green
        TurnIntoGreen(GameObject.FindGameObjectsWithTag("Wall Base"));
        WallNum += 1;
    }

    public void BuildATemple()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(TemplePrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(-18.99f, 2.5f, 8.45f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectsWithTag("Temple Base"));
        TempleNum += 1;
    }

    public void BuildAPraetorium()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(PraetoriumPrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(16.63f, 2.5f, 3.12f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectWithTag("Praetorium Base"));
        PraetoriumNum += 1;
    }

    public void BuildAPrincipia()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(PrincipiaPrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(12.84f, 2.5f, 1.64f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectsWithTag("Principia Base"));
        PrincipiaNum += 1;
    }

    public void BuildATavern()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(TavernPrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(2.36f, 2.5f, 5.18f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectWithTag("Tavern Base"));
        TavernNum += 1;
    }

    public void BuildABarrack()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(BarrackPrefab, InstPos, Quaternion.AngleAxis(163.953f, Vector3.up));
        BarrackNum += 1;
    }

    public void BuildAHorrea()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(HorreaPrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(9.21f, 2.5f, 0.92f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectsWithTag("Horrea Base"));
        HorreaNum += 1;
    }

    public void BuildABathHouse()
    {
        Base.built = false;
        _ = (GameObject)Instantiate(BathHousePrefab, InstPos, new Quaternion(0, 0, 0, 0));
        ArrowInst = (GameObject)Instantiate(Arrow, new Vector3(-2.87f, 2.5f, 8.68f), new Quaternion(0, 0, 0, 0));
        TurnIntoGreen(GameObject.FindGameObjectWithTag("Bath House Base"));
        BathHouseNum += 1;
    }

    public static void DestroyArrow()
    {
        Destroy(ArrowInst);
    }

    public void TurnIntoGreen(GameObject[] Bases)
    {
        foreach (GameObject i in Bases)
            i.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 1, 0.45f, 1);
    }

    public void TurnIntoGreen(GameObject Base)
    {
        Base.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 1, 0.45f, 1);
    }
}
