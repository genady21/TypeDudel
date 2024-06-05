using UnityEngine;

public class FlipPlayer : MonoBehaviour
{
    private bool _facingRight;
    
    private void Update()
    {
        var horizontalInput = InputSystem.HorizontalInput;
        if (horizontalInput > 0)
        {
            if(_facingRight) Flip();
        }
        else if (horizontalInput < 0)
        {
            if(!_facingRight) Flip();
        }
    }
    
    private void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
