using UnityEngine;
using TMPro;  // N�o se esque�a de incluir o namespace do TextMeshPro

namespace TMPro.Examples
{
    using UnityEngine;

    public class StartOnPrimaryScreen : MonoBehaviour
    {
        void Start()
        {
            // Verifica se o jogo est� sendo executado em uma configura��o de v�rias telas.
            if (Display.displays.Length > 1)
            {
                // Obt�m a resolu��o da tela principal
                int width = Screen.currentResolution.width;
                int height = Screen.currentResolution.height;

                // For�a o jogo a iniciar na tela principal (tela 0).
                Screen.SetResolution(width, height, true); // A resolu��o pode ser ajustada conforme necess�rio.
                Display.displays[0].Activate();
            }
            else
            {
                // Caso n�o haja tela secund�ria, ativa a tela principal.
                Display.displays[0].Activate();
            }
        }
    }

}

