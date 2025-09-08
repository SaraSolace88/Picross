using UnityEngine;

public class ColorManager : MonoBehaviour
{
    private int currColor;
    private int levelColors;

    public void SetCurrColor(int i)
    {
        if (i <= levelColors)
        {
            currColor = i;
        }
    }
}
