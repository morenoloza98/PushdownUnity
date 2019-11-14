using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PDA : MonoBehaviour
{
    public void splitFile(List<string> list)
    {
        Dictionary<string, List<string>> productionsDictionary = new Dictionary<string, List<string>>();
        int listSize = list.Count;

        string nonTerminalSymbolsLine;
        List<string> nonTerminalSymbols = new List<string>();

        string terminalSymbolsLine;
        List<string> terminalSymbols = new List<string>();

        string initialSymbol = list[2];

        int remainingLines = listSize - 3;
        string[] productions = new string[remainingLines];
        string[] divideProduction;
        List<string> leftSide = new List<string>();
        List<string> rightSide = new List<string>();


        nonTerminalSymbolsLine = list[0];
        string[] nonTerminalSymbolsSplit = nonTerminalSymbolsLine.Split(',');
        foreach (string i in nonTerminalSymbolsSplit)
        {
            nonTerminalSymbols.Add(i);
        }

        terminalSymbolsLine = list[1];
        string[] terminalSymbolsSplit = terminalSymbolsLine.Split(',');
        foreach (string i in terminalSymbolsSplit)
        {
            terminalSymbols.Add(i);
        }

        for (int i = 0; i < remainingLines; i++)
        {
            productions[i] = list[3 + i];
        }

        for (int i = 0; i < productions.Length; i++)
        {
            divideProduction = productions[i].Split(new string[] { "->" }, System.StringSplitOptions.None);
            string[] temp = divideProduction;
            leftSide.Add(temp[0]);
            rightSide.Add(temp[1]);
        }

        foreach (string ls in nonTerminalSymbols)
        {
            List<string> pd = new List<string>();
            for (int i = 0; i < leftSide.Count; i++)
            {
                if (ls.Equals(leftSide[i]))
                {
                    pd.Add(rightSide[i]);
                }

            }
            productionsDictionary.Add(ls, pd);
        }

        Debug.Log(productionsDictionary);

    }
}
