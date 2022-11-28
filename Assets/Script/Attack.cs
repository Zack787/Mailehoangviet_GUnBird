using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Point p;
    public GameObject blood;
    private void Start()
    {
        p = GameObject.FindObjectOfType<Point>().GetComponent<Point>();
    }
    void OnMouseDown()
    {
        p.point += 100;
        Destroy(gameObject);
        Instantiate(blood, transform.position, Quaternion.identity);
    }
}
