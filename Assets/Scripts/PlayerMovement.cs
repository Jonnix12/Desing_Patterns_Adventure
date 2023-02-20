using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _transform.position += _transform.forward * _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _transform.position += -_transform.right * _speed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            _transform.position += _transform.right * _speed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            _transform.position += -_transform.forward * _speed * Time.deltaTime;

        }
    }
}
