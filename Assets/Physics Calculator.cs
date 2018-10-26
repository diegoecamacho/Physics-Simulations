using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class PhysicsCalculator : MonoBehaviour

{
    private float CoefficientofKinFriction;
    private float objectMass;

    // VF^2 = VI^2 + 2*A*D;





    public static float CalculateFlatForceRequired(float initialVelocity, float finalVelocity,
        float distance, float coefficienofKinematicFriction, float objectMass)
    {
        var topEquation = Mathf.Sqrt(finalVelocity) - Mathf.Sqrt(initialVelocity);
        var bottomEquation = 2 * distance;

        var acceleration = topEquation / bottomEquation;

        var forceApplied = objectMass * acceleration;

        var forceFriction = coefficienofKinematicFriction * objectMass * Physics.gravity.magnitude;

        return forceApplied - forceFriction;





    }
}
