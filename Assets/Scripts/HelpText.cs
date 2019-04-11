using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpText : MonoBehaviour {

    public Text text;
    private string textToDraw = "This game is a turn-based puzzle game." + "\n\n" + "Complete the levels by capturing the ennemies " +
        "and reaching the end of the level." + "\n\n" + "But be carefull, if you finish your turn in front of a guard, you lose !";



    public void Reset()
    {
        text.text = "";
        StopAllCoroutines();
    }

    public void DrawText()
    {
        StartCoroutine(DrawTextRoutine());
    }

    public IEnumerator DrawTextRoutine()
    {
        for (int i = 0; i < textToDraw.Length; i++)
        {
            text.text += textToDraw[i];
            yield return new WaitForSeconds(0.02f);
        }
    }
}
