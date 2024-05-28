using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speed = 25f;
    public Rigidbody2D _rb;
    private float _horizontal;
    public static MovePlayer instance;
    [SerializeField] private Transform _player;
    


    private void Start()
    {
        if (instance == null) instance = this;
    }

    private void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
            _horizontal = Input.acceleration.x;

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            _player.transform.Rotate(0,180,0);
        }

        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            _player.transform.Rotate(0,0,0);
        }

        _rb.velocity = new Vector2(Input.acceleration.x * 10f, _rb.velocity.y);


        var horizontalInput = Input.GetAxis("Horizontal");
        var movement = new Vector2(horizontalInput, 0f);
        var a = movement.x * _speed;
        _rb.velocity = new Vector2(a, _rb.velocity.y);
        
        
       
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone") SceneManager.LoadScene(0);
        TopScore.SaveTopScore(ScoreCounter.HighRuntimeScore);
    }
}