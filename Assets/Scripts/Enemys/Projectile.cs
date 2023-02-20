using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.RedusHp();
        }
        
        Destroy(gameObject);
    }
}
