using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
   [SerializeField] public GameObject[] BottomRooms { get; set; }
   [SerializeField] public GameObject[] TopRooms{ get; set; }
   [SerializeField] public GameObject[] LeftRooms{ get; set; }
   [SerializeField] public GameObject[] RightRooms{ get; set; }
}
