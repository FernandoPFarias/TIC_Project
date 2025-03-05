using UnityEngine;
using TMPro;  // Não se esqueça de incluir o namespace do TextMeshPro

namespace TMPro.Examples
{
    using UnityEngine;

    public class StartOnPrimaryScreen : MonoBehaviour
    {
        void Start()
        {
            // Verifica se o jogo está sendo executado em uma configuração de várias telas.
            if (Display.displays.Length > 1)
            {
                // Obtém a resolução da tela principal
                int width = Screen.currentResolution.width;
                int height = Screen.currentResolution.height;

                // Força o jogo a iniciar na tela principal (tela 0).
                Screen.SetResolution(width, height, true); // A resolução pode ser ajustada conforme necessário.
                Display.displays[0].Activate();
            }
            else
            {
                // Caso não haja tela secundária, ativa a tela principal.
                Display.displays[0].Activate();
            }
        }
    }

}

