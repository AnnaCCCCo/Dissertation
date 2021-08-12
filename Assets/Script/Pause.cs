using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UltimateClean;

public class Pause : MonoBehaviour
{
    public GameObject popupPrefab;

    protected Canvas m_canvas;
    protected GameObject m_popup;

    public static bool isPopup;
    // Start is called before the first frame update
    void Start()
    {
        m_canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPopup == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                m_popup = Instantiate(popupPrefab, m_canvas.transform, false);
                m_popup.SetActive(true);
                m_popup.transform.localScale = Vector3.zero;
                m_popup.GetComponent<Popup>().Open();

                isPopup = true;
            }
        }
    }

    public void setIsPopup(bool b)
    {
        isPopup = b;
    }
}
