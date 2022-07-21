using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    public float speed =200;

    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        StartingRandomVel();
    }

    private void StartingRandomVel(){
        float x = Random.value > 0.5f ? 1f : -1f;
        float y = Random.value > 0.5f ? Random.Range(-1f, -.5f) : Random.Range(.5f, 1f);

        _rigidbody.AddForce(new Vector2(x, y) * this.speed);
    }

    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }

    public void ResetPosition(){
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
        StartingRandomVel();
    }
}
