using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public static float HorizontalInput { get; private set; }

    public void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
}
