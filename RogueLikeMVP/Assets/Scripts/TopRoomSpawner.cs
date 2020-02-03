using UnityEngine;

public class TopRoomSpawner : RoomSpawner
{
    protected override void SpawnRoom()
    {
        int rand = Random.Range(0, templates.TopRooms.Length);
        Instantiate(templates.TopRooms[rand]);
    }
}