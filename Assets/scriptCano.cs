using UnityEngine;

public class CanoFlappyBird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var bird = other.gameObject.GetComponent<FlappyBidPlayer>();
        if (bird != null)
        {
            Debug.Log("Game Over!");
        }
    }
}



using UnityEngine;

public class FlappyBidPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float jumpSpeed = 5f;
    private Rigidbody2D _rb20;
    void Awake()
    {
        _rb20 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Pular();
        SubiuDemais();
    }

    private void Pular()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        _rb20.velocity = Vector2.up * jumpSpeed;
    }

    public void SubiuDemais()
    {
        if (transform.position.y > 5)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
    }
}
