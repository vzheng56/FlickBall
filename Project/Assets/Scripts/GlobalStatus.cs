using UnityEngine;
using System.Collections;

public class GlobalStatus {

   public enum BallStatus
    { 
        BallStatus_WaitShoot =0,
        BallStatus_Rolling
    }

    public static BallStatus CurrentBallStatus = BallStatus.BallStatus_WaitShoot;

}
