using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    [SerializeField] private int colorValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(colorValue);
        collision.gameObject.GetComponent<ColorManager>().SetCurrColor(colorValue);
    }
}
