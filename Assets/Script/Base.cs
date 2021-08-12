using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public bool isBeenCovered;
    public bool willBeCovered;

    public static bool built;
    // Start is called before the first frame update
    void Start()
    {
        isBeenCovered = false;
        willBeCovered = false;
        built = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeenCovered)
            this.gameObject.SetActive(false);
        else
            this.gameObject.SetActive(true);

        if (willBeCovered)
            this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 1, 0.45f, 1);
        else
        {
            if (this.gameObject.CompareTag("Base") || this.gameObject.CompareTag("Barrack Base"))
                this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);
        }

        if (built)
        {
            if (this.willBeCovered)
                this.isBeenCovered = true;
        }
    }

    public void SetIsBeenCovered(bool a)
    {
        isBeenCovered = a;
    }

    public void SetWillBeCovered(bool a)
    {
        willBeCovered = a;
    }
}
