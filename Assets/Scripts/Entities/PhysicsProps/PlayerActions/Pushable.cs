using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("PhysicsProps/Pushable")]
[RequireComponent(typeof(Rigidbody))]
public class Pushable : PhysicsProp {

    public void Push(Vector3 force) {
        rigidbody.AddForce(force);
    }
}
