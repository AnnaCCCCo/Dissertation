using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBuildings : MonoBehaviour
{
    public TextMeshProUGUI ScriptText;
    public GameObject ScriptTextPanel;

    private string BuildingName;
    private GameObject ThisBuilding;

    public static bool IsPopupOpen;
    // Start is called before the first frame update
    private void Start()
    {
        ScriptTextPanel.gameObject.SetActive(false);
        IsPopupOpen = false;
        ThisBuilding = null;
    }

    // Update is called once per frame
    private void Update()
    {
        if (IsPopupOpen == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (ScriptTextPanel.activeSelf == false)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        BuildingName = hit.transform.name;
                    }
                    BuildingScript();
                }
                else
                {
                    if (ThisBuilding.GetComponent<Outline>().isActiveAndEnabled == true)
                    {
                        ThisBuilding.GetComponent<Outline>().enabled = false;
                    }
                    ScriptTextPanel.gameObject.SetActive(false);
                }
            }
        }
    }
    
    private void BuildingScript()
    {
        if (BuildingName == "Tavern")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetTavern();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Tavern, also named Popina, was a type of wine bar generally visited by lower-classes and slaves, and was simply furnished with stools and tables. " +
                "Because it was associated with gambling and prostitution, the popina was seen by respectable Romans as places of crime and violence." +
                "\r\n" +
                "\r\n" +
                " ";
        }
        else if (BuildingName == "Principia")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetPrincipia();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Principia." +
                "\r\n" +
                "\r\n" +
                "You've choose the Principia.";
        }
        else if (BuildingName == "Walls")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetWalls();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Walls." +
                "\r\n" +
                "\r\n" +
                "You've choose the Walls.";
        }
        else if (BuildingName == "Praetorium")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetPraetorium();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Praetorium." +
                "\r\n" +
                "\r\n" +
                "You've choose the Praetorium.";
        }
        else if (BuildingName == "Temple")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetTemple();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Temple." +
                "\r\n" +
                "\r\n" +
                "You've choose the Temple.";
        }
        else if (BuildingName == "Horrea 1" || BuildingName == "Horrea 2")
        {
            ScriptTextPanel.gameObject.SetActive(true);

            if (BuildingName == "Horrea 1")
                ThisBuilding = BuildingsControl.GetHorrea1();
            else
                ThisBuilding = BuildingsControl.GetHorrea2();

            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Horrea." +
                "\r\n" +
                "\r\n" +
                "You've choose the Horrea.";
        }
        else if (BuildingName == "Bath House")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetBathHouse();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "You've choose the Bath House." +
                "\r\n" +
                "\r\n" +
                "You've choose the Bath House.";
        }
        else
        {
            ScriptTextPanel.gameObject.SetActive(false);
            ThisBuilding.GetComponent<Outline>().enabled = false;
        }
    }
}
