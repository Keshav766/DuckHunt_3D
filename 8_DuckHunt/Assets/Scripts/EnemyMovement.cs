using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;
    public int positiveYMovement = 1;
    public int positiveXMovement = 1;
    int index1;
    int index2;

    int[] movement = { 1, -1 };

    void Start()
    {
        index1 = GenerateIndex();
        index2 = GenerateIndex();
        positiveXMovement = movement[index1];
        positiveYMovement = movement[index2];
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * positiveYMovement);
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * positiveXMovement);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundry")
        {
            positiveYMovement = -positiveYMovement;
        }
        else if (other.tag == "Boundry2")
        {
            positiveXMovement = -positiveXMovement;
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    int GenerateIndex()
    {
        return Random.Range(0, 2);
    }

}
