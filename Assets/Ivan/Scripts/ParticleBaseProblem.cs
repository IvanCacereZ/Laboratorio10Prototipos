using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParticleBaseProblem : MonoBehaviour
{
    [Header("Particle Problem")]
    [SerializeField] protected float QuantityParticles;
    protected List<MyParticle> ParticleList;
    protected abstract void Start();
    protected List<Vector3> GetStartPositions()
    {
        List<Vector3> ParticlePos = new();
        for (int i = 0; i < QuantityParticles; i++)
        {
            ParticlePos.Add(new Vector3());
        }
        return ParticlePos;
    }
}
public class MyParticle
{
    public float velocity;
    public float sizeInitial;
    public Material myMat;
}
