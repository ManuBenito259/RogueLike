using UnityEngine;

public class LeftRoomSpawner : RoomSpawner
{
    protected override void SpawnRoom()
    {
        int rand = Random.Range(0, templates.LeftRooms.Length);
        Instantiate(templates.LeftRooms[rand]);
    }
}