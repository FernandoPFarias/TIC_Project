using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    void Start()
    {
        // Verifica se o jogo está sendo executado em uma configuração de várias telas.
        if (Display.displays.Length > 1)
        {
            // Força o jogo a iniciar na tela principal (tela 0).
            Screen.SetResolution(1920, 1080, true); // A resolução pode ser ajustada conforme necessário.
            Display.displays[0].Activate();
        }
        else
        {
            // Caso não haja tela secundária, ativa a tela principal.
            Display.displays[0].Activate();
        }
    }
}
