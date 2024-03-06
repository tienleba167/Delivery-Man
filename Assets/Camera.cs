using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]  GameObject CarToFollow;
    void LateUpdate() {
        transform.position = CarToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
