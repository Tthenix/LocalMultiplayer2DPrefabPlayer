using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    Player player;

    [SerializeField] List<GameObject> prefabs = new List<GameObject>();
    [SerializeField] Transform playerSpawnLeft;
    [SerializeField] Transform playerSpawnRight;

    private void Start()
    {
        // Instancia al jugador en una posición aleatoria (izquierda o derecha).
        Vector3 spawnPosition = Random.Range(0, 2) == 0 ? playerSpawnLeft.position : playerSpawnRight.position;
        player = GameObject.Instantiate(prefabs[Random.Range(0, prefabs.Count)], spawnPosition, Quaternion.identity).GetComponent<Player>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (player)
            player.Move(context.ReadValue<Vector2>());
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (player && context.started)
        {
            player.Shoot();
        }
    }
}