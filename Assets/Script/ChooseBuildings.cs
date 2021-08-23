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
                "There had a limited menu of simple foods (olives, bread, stews) and selection of wines of varying quality. " +
                "\r\n" +
                "Because it was associated with gambling and prostitution, the popina was seen by respectable Romans as places of crime and violence. " +
                "Although gambling with dice was illegal, it would appear from the large number of dice found at cities like Pompeii that most people ignored this law. ";
        }
        else if (BuildingName == "Principia")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetPrincipia();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Principia was the central plaza or headquarters in a Roman fort. " +
                "The central part of the headquarters was occupied by a vast internal courtyard, which was just an empty space to express loyalty to the emperor and his family, military discipline, and those elements of Roman religiosity." +
                "\r\n" +
                "When the day starts at daybreak, the soldiers arose at this time and shortly after collected in the company area for breakfast and assembly. " +
                "The centurions were up before them and off to the principia where they and the equites were required to assemble.";
        }
        else if (BuildingName == "Walls")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetWalls();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Vindolanda was a small city, so the city walls only have two gates.";
        }
        else if (BuildingName == "Praetorium")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetPraetorium();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Praetorium originally referred to a general's tent in a Roman fort and derived from the title praetor, which referred to a Roman magistrate. " +
                "The war-council meetings held in a general's tent gave administrative and juridical meanings to the term \"Praetorium\", a usage continued into the Byzantine Empire, where the term identified the residence of the governor of a city." +
                "\r\n" +
                "Most praetoriums had areas surrounding them delegated for exercise and drills conducted by the troops. " +
                "The area ahead of the camp would be occupied by the tents housing the commander's soldiers.";
        }
        else if (BuildingName == "Temple")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetTemple();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Ancient Roman temples were the most important buildings in Roman culture, though only a few survive in any sort of complete state. " +
                "Today they remain \"the most obvious symbol of Roman architecture\". No matter how small the town was, they had to have at least one main temple. " +
                "\r\n" +
                "Public religious ceremonies of the official Roman religion took place outdoors and not within the temple building. " +
                "Some ceremonies were processions that started at, visited, or ended with a temple or shrine, where a ritual object might be stored and brought out for use, or where an offering would be deposited.";
        }
        else if (BuildingName == "Horrea 1" || BuildingName == "Horrea 2")
        {
            ScriptTextPanel.gameObject.SetActive(true);

            if (BuildingName == "Horrea 1")
                ThisBuilding = BuildingsControl.GetHorrea1();
            else
                ThisBuilding = BuildingsControl.GetHorrea2();

            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Horreum (plural: horrea) was a type of public warehouse. " +
                "Although the Latin term is often used to refer to granaries, Roman horreum was used to store many types of essentials such as olive oil, wine, food, clothing, and even marble. ";
        }
        else if (BuildingName == "Bath House")
        {
            ScriptTextPanel.gameObject.SetActive(true);
            ThisBuilding = BuildingsControl.GetBathHouse();
            ThisBuilding.GetComponent<Outline>().enabled = true;

            ScriptText.text = "Bathhouse (Thermae or Balneae from Greek) were the bathing facilities. " +
                "Most Roman cities had at least one such building, which was a centre for bathing and socialising and reading. " +
                "One crucial function of baths in Roman society was considered a \"branch library\" today. " +
                "Because the bathing process took such long time, conversations were necessary.";
        }
        else
        {
            ScriptTextPanel.gameObject.SetActive(false);
            ThisBuilding.GetComponent<Outline>().enabled = false;
        }
    }
}
