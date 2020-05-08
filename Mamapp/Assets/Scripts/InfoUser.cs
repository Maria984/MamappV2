using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosUsuario.php"; //http://soymariaojeda.com/

    //public Text TextoNombre;
    //public Text TextoCorreo;
    //public Text TextoContrasena;
    //public Text NombreUsuario;

    public int idUser = 8;

    void Start()
    {
        
    }

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlPosition + "?IDuser=" + idUser;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);
        
        //NombreUsuario.text = resultInfo.text; 
    }






}