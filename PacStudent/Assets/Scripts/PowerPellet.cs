using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet : Collectable
{

    protected override void collected(Collider2D coll)
    {
        //GameManager.makeGhostsVulnerable();
        base.collected(coll);
    }
}
