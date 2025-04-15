using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVacaciones : MonoBehaviour
{
    public int infantiles;
    public int juveniles;
    int profesor;
    int coordinador;
    int restoInfa;
    int restoJuve;

    // Start is called before the first frame update
    void Start()
    {
        profesor = (infantiles / 10) + (juveniles / 20);
        coordinador = profesor / 5;
        restoInfa = (infantiles % 10);
        restoJuve = (juveniles % 20);

        Debug.Log(profesor);
        Debug.Log(coordinador);
        Debug.Log(restoInfa);


        if ((infantiles < 0 || juveniles < 0) || (infantiles > 100 || juveniles > 100))
        {
            Debug.Log("Número de personas ingresado no válido");
            return;
        }
        if (restoInfa > 0)
        {

        }

    }   
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
