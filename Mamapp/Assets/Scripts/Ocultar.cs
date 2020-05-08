using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ocultar : MonoBehaviour
{
    
    [SerializeField] private GameObject ocultar2;
    [SerializeField] private GameObject ocultar3;

    [SerializeField] private GameObject img4;
    [SerializeField] private GameObject img5;

    public GameObject textLinea;
    public GameObject textTitulo;

    public float borrar = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (borrar >= 0)
        {
            textLinea.GetComponent<Text>().text = "Tiempo";
            textTitulo.GetComponent<Text>().text = "Mueve la línea de tiempo";
            textTitulo.GetComponent<Text>().fontSize = 74;            
            ocultar2.SetActive(false);
            ocultar3.SetActive(false);
        }
        if (borrar >= 1)
        {
            textLinea.GetComponent<Text>().text = "22 Semanas";
            textTitulo.GetComponent<Text>().text = "Estrés";
            textTitulo.GetComponent<Text>().fontSize = 150;
            ocultar2.SetActive(true);
            ocultar3.SetActive(false);
        }
        if (borrar >= 2)
        {
            textLinea.GetComponent<Text>().text = "Fin";
            textTitulo.GetComponent<Text>().text = "¿Qué deseas hacer?";
            textTitulo.GetComponent<Text>().fontSize = 74;
            ocultar2.SetActive(false);
            ocultar3.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            img4.SetActive(true);
            textLinea.GetComponent<Text>().text = "22 Semanas";
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            img4.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            img5.SetActive(true);
            textLinea.GetComponent<Text>().text = "22 Semanas";
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            img5.SetActive(false);
        }
    }

    public void ToggleAnalog(float newBorrar)
    {
        borrar = newBorrar;
    }
}
