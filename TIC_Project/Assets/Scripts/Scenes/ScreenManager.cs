using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    void Start()
    {
        // Verifica se o jogo est� sendo executado em uma configura��o de v�rias telas.
        if (Display.displays.Length > 1)
        {
            // For�a o jogo a iniciar na tela principal (tela 0).
            Screen.SetResolution(1920, 1080, true); // A resolu��o pode ser ajustada conforme necess�rio.
            Display.displays[0].Activate();
        }
        else
        {
            // Caso n�o haja tela secund�ria, ativa a tela principal.
            Display.displays[0].Activate();
        }
    }
}
