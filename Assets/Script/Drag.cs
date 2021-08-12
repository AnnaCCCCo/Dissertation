using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 selfScenePosition;
    private Vector3 rot;

    private float posY;

    private bool isIns;
    private string BuildingName;

    // Start is called before the first frame update
    void Start()
    {
        isIns = false;
        BuildingName = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (isIns)
        {
            //Change self coordinate to screen coordinate
            myTransform = this.GetComponent<Transform>();
            selfScenePosition = Camera.main.WorldToScreenPoint(myTransform.position);
            myTransform.localRotation = Quaternion.Euler(rot);

            //New screen coordinate
            Vector3 currentScenePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, selfScenePosition.z);

            //Change screen coord to world coord, freeze Y
            Vector3 crrrentWorldPosition = new Vector3(Camera.main.ScreenToWorldPoint(currentScenePosition).x, posY, Camera.main.ScreenToWorldPoint(currentScenePosition).z);

            //Set component pos to mouse's world pos
            myTransform.position = crrrentWorldPosition;
            if (Input.GetKeyDown(KeyCode.Q))
                rot.y += 90.0f;
            if (Input.GetKeyDown(KeyCode.E))
                rot.y -= 90.0f;
        }
    }

    private void OnMouseUp()
    {
        if (isIns && BuildingName != null)
        {
            isIns = false;
            Base.built = true;
            this.GetComponent<BoxCollider>().isTrigger = true;

            if (BuildingName == "Vicus")
            {
                ResourceTexts.BuildAVicus();
            }

            if (BuildingName == "Barrack")
            {
                ResourceTexts.BuildABarrack();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isIns = true;
            posY = this.GetComponent<Transform>().position.y;
            rot.x = this.GetComponent<Transform>().rotation.x;
            rot.y = this.GetComponent<Transform>().rotation.y;
            rot.z = this.GetComponent<Transform>().rotation.z;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Base") && this.gameObject.CompareTag("Vicus"))
        {
            other.gameObject.GetComponent<Base>().SetWillBeCovered(true);
            BuildingName = "Vicus";
        } 

        if (other.gameObject.CompareTag("Barrack Base") && this.gameObject.CompareTag("Barrack"))
        {
            other.gameObject.GetComponent<Base>().SetWillBeCovered(true);
            BuildingName = "Barrack";
        }  

        if (other.gameObject.CompareTag("Wall Base") && this.gameObject.CompareTag("Wall"))
        {
            GameObject[] Bases = GameObject.FindGameObjectsWithTag("Wall Base");
            foreach (GameObject i in Bases)
                i.SetActive(false);
            BuildingsControl.GetWalls().SetActive(true);
            Destroy(this.gameObject);
            BuildingButton.DestroyArrow();
        }

        if (other.gameObject.CompareTag("Principia Base") && this.gameObject.CompareTag("Principia"))
        {
            GameObject[] Bases = GameObject.FindGameObjectsWithTag("Principia Base");
            foreach(GameObject i in Bases)
                i.SetActive(false);
            BuildingsControl.GetPrincipia().SetActive(true);
            Destroy(this.gameObject);
            ResourceTexts.SatisfactionIncrease(20);
            BuildingButton.DestroyArrow();
        }

        if (other.gameObject.CompareTag("Praetorium Base") && this.gameObject.CompareTag("Praetorium"))
        {
            other.gameObject.GetComponent<Base>().SetIsBeenCovered(true);
            BuildingsControl.GetPraetorium().SetActive(true);
            Destroy(this.gameObject);
            ResourceTexts.SatisfactionIncrease(20);
            BuildingButton.DestroyArrow();
        }

        if (other.gameObject.CompareTag("Tavern Base") && this.gameObject.CompareTag("Tavern"))
        {
            other.gameObject.GetComponent<Base>().SetIsBeenCovered(true);
            BuildingsControl.GetTavern().SetActive(true);
            Destroy(this.gameObject);
            ResourceTexts.SatisfactionIncrease(20);
            BuildingButton.DestroyArrow();
        }

        if (other.gameObject.CompareTag("Temple Base") && this.gameObject.CompareTag("Temple"))
        {
            GameObject[] Bases = GameObject.FindGameObjectsWithTag("Temple Base");
            foreach (GameObject i in Bases)
                i.SetActive(false);
            BuildingsControl.GetTemple().SetActive(true);
            Destroy(this.gameObject);
            ResourceTexts.SatisfactionIncrease(20);
            BuildingButton.DestroyArrow();
        }

        if(other.gameObject.CompareTag("Horrea Base") && this.gameObject.CompareTag("Horrea"))
        {
            other.gameObject.GetComponent<Base>().SetIsBeenCovered(true);
            GameObject base1 = GameObject.Find("Horrea Base 1");
            GameObject base2 = GameObject.Find("Horrea Base 2");

            ResourceTexts.SatisfactionIncrease(10);
            Destroy(this.gameObject);
            BuildingButton.DestroyArrow();

            if (other.gameObject.name == "Horrea Base 1")
            {
                BuildingsControl.GetHorrea1().SetActive(true);
                if (base2.activeSelf)
                    base2.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);
            }
            else if (other.gameObject.name == "Horrea Base 2")
            {
                BuildingsControl.GetHorrea2().SetActive(true);
                if (base1.activeSelf)
                    base1.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);
            }
        }

        if(other.gameObject.CompareTag("Bath House Base")&&this.gameObject.CompareTag("Bath House"))
        {
            other.gameObject.GetComponent<Base>().SetIsBeenCovered(true);
            BuildingsControl.GetBathHouse().SetActive(true);
            Destroy(this.gameObject);
            ResourceTexts.SatisfactionIncrease(20);
            BuildingButton.DestroyArrow();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            other.gameObject.GetComponent<Base>().SetWillBeCovered(false);
            BuildingName = null;
        }
            

        if (other.gameObject.CompareTag("Barrack Base"))
            other.gameObject.GetComponent<Base>().SetWillBeCovered(false);
    }
}
