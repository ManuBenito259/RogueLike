using UnityEngine;

public class RightRoomSpawner : RoomSpawner
{
    protected override void SpawnRoom()
    {
        int rand = Random.Range(0,4);
        Debug.Log("right spawn:" + rand + "at:" + transform.position);
        GameObject r = Instantiate(templates.GetLeftRooms(rand),transform.position, Quaternion.identity);
        var spawns= r.GetComponentsInChildren<RoomSpawner>();
        foreach (var s in spawns)
        {
            s.SetTemplate(templates);
            
        }

        isSpawned = true;
    }
}