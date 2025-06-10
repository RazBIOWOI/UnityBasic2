using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class STAR1 : MonoBehaviour
{
    public TextMeshProUGUI starTextUI;

    void Start()
    {
        int maxStars = 5;
        string fullText = "";

        for (int i = 1; i <= maxStars; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                fullText += "¡Ú ";
            }
            fullText += "\n";
        }

        for (int i = maxStars - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                fullText += "¡Ú ";
            }
            fullText += "\n";
        }

        starTextUI.text = fullText;
    }
}
