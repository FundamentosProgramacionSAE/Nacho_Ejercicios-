using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaperoomController : MonoBehaviour
{
    public bool btn1 = false;
    public bool btn2 = false;
    public bool btn3 = false;
    public bool btn4 = false;
    public GameObject _btn1;
    public GameObject _btn2;
    public GameObject _btn3;
    public GameObject _btn4;
    public GameObject camara;
    public AudioClip Win;
    public void PrimerBoton()
    {
        btn1 = true;
        _btn1.SetActive(false);
    }

    public void SegundoBoton()
    {
        if (btn1 == true)
        {
            btn2 = true;
            _btn2.SetActive(false);
        }
        else
        {
            fallo();
        }
    }

    public void TercerBoton()
    {
        if (btn2 == true)
        {
            btn3 = true;
            _btn3.SetActive(false);
        }
        else
        {
            fallo();
        }
    }

    public void CuartoBoton()
    {
        if (btn3 == true)
        {
            btn4 = true;
            _btn4.SetActive(false);
        }
        else
        {
            fallo();
        }
    }

    public void BotonFinal()
    {
        if (btn4 == true)
        {
            AudioSource.PlayClipAtPoint(Win, camara.transform.position);
            Debug.Log("Win");
        }
    }

    private void fallo()
    {
        btn1 = false;
        btn2 = false;
        btn3 = false;
        btn4 = false;
        _btn1.SetActive(true);
        _btn2.SetActive(true);
        _btn3.SetActive(true);
        _btn4.SetActive(true);
    }
}
