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
    private Rigidbody2D _rb20;
    void Awake()
    {
        _rb20 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
    }
}
