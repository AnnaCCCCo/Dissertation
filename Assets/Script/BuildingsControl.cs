using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsControl : MonoBehaviour
{
    private static GameObject Walls;
    private static GameObject Temple;
    private static GameObject Praetorium;
    private static GameObject Principia;
    private static GameObject Tavern;
    private static GameObject Horrea1;
    private static GameObject Horrea2;
    private static GameObject BathHouse;

    void Start()
    {
        Walls = GameObject.Find("Walls");
        Walls.SetActive(false);
        Walls.GetComponent<Outline>().enabled = false;

        Temple = GameObject.Find("Temple");
        Temple.SetActive(false);
        Temple.GetComponent<Outline>().enabled = false;

        Praetorium = GameObject.Find("Praetorium");
        Praetorium.SetActive(false);
        Praetorium.GetComponent<Outline>().enabled = false;

        Principia = GameObject.Find("Principia");
        Principia.SetActive(false);
        Principia.GetComponent<Outline>().enabled = false;

        Tavern = GameObject.Find("Tavern");
        Tavern.SetActive(false);
        Tavern.GetComponent<Outline>().enabled = false;

        Horrea1 = GameObject.Find("Horrea 1");
        Horrea1.SetActive(false);
        Horrea1.GetComponent<Outline>().enabled = false;

        Horrea2 = GameObject.Find("Horrea 2");
        Horrea2.SetActive(false);
        Horrea2.GetComponent<Outline>().enabled = false;

        BathHouse = GameObject.Find("Bath House");
        BathHouse.SetActive(false);
        BathHouse.GetComponent<Outline>().enabled = false;
    }

    public static GameObject GetWalls()
    {
        return Walls;
    }

    public static GameObject GetTemple()
    {
        return Temple;
    }

    public static GameObject GetPraetorium()
    {
        return Praetorium;
    }

    public static GameObject GetPrincipia()
    {
        return Principia;
    }

    public static GameObject GetTavern()
    {
        return Tavern;
    }

    public static GameObject GetHorrea1()
    {
        return Horrea1;
    }

    public static GameObject GetHorrea2()
    {
        return Horrea2;
    }

    public static GameObject GetBathHouse()
    {
        return BathHouse;
    }
}
