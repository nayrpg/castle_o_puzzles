using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySharedItem : SharedItem {
    private Utilities utils;

    public float reach_distance = 5f;
    public float explosion_radius = 1f;
    // Use this for initialization

    public override void Start() {
        base.Start();
        utils = Utilities.Instance;
    }

    public override void Update() {
        if (SharedItemButtonPress()) {
            TryLockToggle();
        }
    }

    protected void TryLockToggle() {
        CameraController cam = PlayerDataList.Instance["CameraController"] as CameraController;
        IOLock iolock = utils.RayCastExplosiveSelect<IOLock>(cam.transform.position, cam.transform.forward.normalized * reach_distance, explosion_radius);
        if(iolock != null) {   
            iolock.RequestLockStateChange(!iolock.Locked.state);
        }
    }
}
