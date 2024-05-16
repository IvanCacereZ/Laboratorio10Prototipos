using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFlyWeight : ParticleBaseProblem
{
    protected List<Vector3> startPositions;
    [SerializeField] protected Material matGeneral;

    protected override void Start()
    {
        startPositions = GetStartPositions();

    }
}
