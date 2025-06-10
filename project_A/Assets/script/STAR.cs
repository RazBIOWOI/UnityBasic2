using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class STAR : MonoBehaviour
{
    public TextMeshProUGUI starTextUI;

    void Start()
    {
        string allPhases = "";

        allPhases += Phase1();
        allPhases += "\n\n";
        allPhases += Phase2();
        allPhases += "\n\n";
        allPhases += Phase3();
        allPhases += "\n\n";
        allPhases += Phase4();
        allPhases += "\n\n";
        allPhases += Phase5();

        starTextUI.text = allPhases;
    }

    public string Phase1()
    {
        int star = 5;
        string fullText = "¢º Phase 1 ¢¸\n";

        for (int i = 1; i <= star; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                fullText += "¡Ú ";
            }
            fullText += "\n";
        }
        return fullText;
    }

    public string Phase2()
    {
        int starCount = 5;
        string result = "¢º Phase 2 ¢¸\n";

        for (int i = 1; i <= starCount; i++)
        {
            for (int j = 1; j <= starCount - i; j++)
            {
                result += "\u00A0\u00A0";
            }
            for (int k = 1; k <= i; k++)
            {
                result += "¡Ú ";
            }
            result += "\n";
        }

        return result;
    }

    public string Phase3()
    {
        int max = 5;
        string result = "¢º Phase 3 ¢¸\n";

        for (int i = 1; i <= max; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "¡Ú ";
            }
            result += "\n";
        }

        for (int i = max - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "¡Ú ";
            }
            result += "\n";
        }

        return result;
    }

    public string Phase4()
    {
        int max = 5;
        string result = "¢º Phase 4 ¢¸\n";

        for (int i = max; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "¡Ú ";
            }
            result += "\n";
        }

        return result;
    }

    public string Phase5()
    {
        int max = 5;
        string result = "¢º Phase 5 ¢¸\n";

        
        for (int i = 1; i <= max; i++)
        {
            for (int s = 1; s <= max - i; s++)
            {
                result += "\u00A0\u00A0";
            }
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                result += "¡Ú";
            }
            result += "\n";
        }

        
        for (int i = max - 1; i >= 1; i--)
        {
            for (int s = 1; s <= max - i; s++)
            {
                result += "\u00A0\u00A0";
            }
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                result += "¡Ú";
            }
            result += "\n";
        }

        return result;
    }
}
