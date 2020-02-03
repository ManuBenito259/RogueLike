using UnityEngine;

public class BottomRoomSpawner : RoomSpawner
{
    protected override void SpawnRoom()
    {
        int rand = Random.Range(0, templates.BottomRooms.Length);
        Instantiate(templates.BottomRooms[rand]);
    }
}