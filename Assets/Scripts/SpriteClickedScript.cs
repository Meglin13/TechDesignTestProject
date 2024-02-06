using UnityEngine;
using UnityEngine.Events;

public class SpriteClickedScript : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnClick;

    private void OnMouseDown() => OnClick?.Invoke();
}