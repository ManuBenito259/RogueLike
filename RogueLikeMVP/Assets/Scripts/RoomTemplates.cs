
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
   [SerializeField] private GameObject[] _bottomRooms;
   [SerializeField] private GameObject[] _topRooms;
   [SerializeField] private GameObject[] _leftRooms;
   [SerializeField] private GameObject[] _rightRooms;

   public GameObject  GetBottomRooms(int i)
   {
       return _bottomRooms[i];
   }
   
   public GameObject GetTopRooms(int i)
   {
       return _topRooms[i];
   }
   
   public GameObject GetLeftRooms(int i)
   {
       return _leftRooms[i];
   }
   
   public GameObject GetRightRooms(int i)
   {
       return _rightRooms[i];
   }

  // public GameObject[] BottomRooms{ get; set; }
  // 
  // public GameObject[] TopRooms{ get; set; }
  // 
  // public GameObject[] LeftRooms{ get; set; }
  // public GameObject[] RightRooms{ get; set; }
  
}
