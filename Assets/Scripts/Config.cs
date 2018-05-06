using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Confiiguration", menuName = "Create configuration of game")]
public class Config : ScriptableObject {

    public float speedOfRoad;
    public float speedOfMoving;
    public float interval;
    public Transform StartBoard;
    public Transform EndBoard;

}
