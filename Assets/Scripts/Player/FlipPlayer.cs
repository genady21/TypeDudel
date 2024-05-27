using UnityEngine;

public class FlipPlayer : MonoBehaviour
{
    private bool _facingRight;
    
    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0)
        {
            if(_facingRight) Flip();
        }
        else if (horizontalInput < 0)
        {
            if(!_facingRight) Flip();
        }

        Debug.Log(horizontalInput);
    }
    
    private void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
