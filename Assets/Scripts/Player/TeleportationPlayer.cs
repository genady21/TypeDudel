using UnityEngine;

public class TeleportationPlayer : MonoBehaviour
{
    [SerializeField] private float _screenWidth = 10f;

    private void Update()
    {
        var position = transform.position;
        if (position.x > _screenWidth / 2)
            position.x = -_screenWidth / 2;
        else if (position.x < -_screenWidth / 2) position.x = _screenWidth / 2;

        transform.position = position;
    }
}