using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  void Start ()
  {
  }
  void Update ()
  {
    transform.RotateAround(Vector3.zero, Vector3.forward, 200*Time.deltaTime);
  }
}
