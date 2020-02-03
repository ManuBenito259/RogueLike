using UnityEngine;

public class RightRoomSpawner : RoomSpawner
{
    protected override void SpawnRoom()
    {
        int rand = Random.Range(0, templates.RightRooms.Length);
        Instantiate(templates.RightRooms[rand]);
    }
}