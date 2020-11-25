using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    [SerializeField][Range(0f,1f)]
    private float speed = 1f;
    [SerializeField][Range(0f,1000f)]
    private float mousense = 100f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        player.Move((new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")))*speed);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime*mousense);
    }
}
