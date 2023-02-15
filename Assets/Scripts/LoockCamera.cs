using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoockCamera : MonoBehaviour {

    [SerializeField]
    private Transform player;

    [SerializeField]
    private float smoothTime = 5F;

    [SerializeField]
    private Vector3 offset = new Vector3(-2, 1, 0);

    [SerializeField]
    private float speed = 5f;

    private bool endLadder = false;


    private void Update() {
        if(endLadder) {
            this.transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * smoothTime);         

            var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

        }
    }
    public void MoveCam() {
        endLadder = true;
    }

    public void MoveToLand() {
        offset = new Vector3(-1f, 1f, -3f);
    }

    public void CastleCam() {
        offset = new Vector3(0, 1f, 0);
    }

    public void EndMoveCamera() {
        offset = new Vector3(0, 0.3f, -2f);
    }
}
