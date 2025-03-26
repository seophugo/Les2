using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private GameObject _bulletPrefab;
    private List<GameObject> _bullets = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(_speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, _speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            _bullets.Add(newBullet);
        }

        for (int i = 0; i < _bullets.Count; i++)
        {
            if (_bullets[i] != null)
            {
                MoveBullet(_bullets[i]);
            }
        }
    }

    private void Move(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime;
    }

    private void MoveBullet(GameObject bullet)
    {
        bullet.transform.position += new Vector3(0, 7, 0) * Time.deltaTime;
    }
}
