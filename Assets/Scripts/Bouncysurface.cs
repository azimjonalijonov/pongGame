using UnityEngine;

public class Bouncysurface : MonoBehaviour
{
    public float bounceStrengh;
    public bool isPaddle = false;
    public AudioSource bounceSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball!=null){
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrengh);

            if(this.isPaddle){
                bounceSound.Play();
            }
        }
    }
}
