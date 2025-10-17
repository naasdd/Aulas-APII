using UnityEngine;

public class ProjetilITJ : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    [SerializeField] private float projectileSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        
        _rb2D.velocity = transform.up * projectileSpeed;
    }
}
