using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappLikeABird : MonoBehaviour
{
    public float flapHeight = 5f;
    private Rigidbody2D rb;
    public InputAction flapAction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flapAction.performed += _ => Flap(); // Subscribe to the flap action
        flapAction.Enable(); // Enable the flap action
    }

    void OnDestroy()
    {
        flapAction.Disable(); // Disable the flap action when the object is destroyed
    }

    private void Flap()
    {
        rb.velocity = Vector2.up * flapHeight;
    }
}
