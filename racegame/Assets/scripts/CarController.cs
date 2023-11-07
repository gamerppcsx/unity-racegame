using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput, verticalInput, acceHandler;
    private float currentSteerAngle, currentbreakForce;
    //private bool isBreaking;
    private float isBreaking;
    private bool BreakingBool;
    public float KPH;

    // apelsaps
    // Settings
    [SerializeField] private float motorForce, breakForce, maxSteerAngle;
    [SerializeField] private float maxAccelaration;

    // Wheel Colliders
    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider, rearRightWheelCollider;

    // Wheels
    [SerializeField] private Transform frontLeftWheelTransform, frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform, rearRightWheelTransform;

    private void FixedUpdate() {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();


        /*float force = verticalInput * motorForce;
        float 
        Vector3 horizontalVelocity = velocity;
        horizontalVelocity = new Vector3(velocity.x, 0, velocity.z);

        // The speed on the x-z plane ignoring any speed
        float horizontalSpeed = horizontalVelocity.magnitude;
        // The speed from gravity or jumping
        float verticalSpeed  = velocity.y;
        // The overall speed
        float overallSpeed = velocity.magnitude;
        KPH = overallSpeed;*/
        var vel = GetComponent<Rigidbody>().velocity;      //to get a Vector3 representation of the velocity
        KPH = vel.magnitude;  
    }

    private void GetInput() {
        // Steering Input
        horizontalInput = Input.GetAxis("Horizontal");

        // Acceleration Input
        verticalInput = Input.GetAxis("Vertical");

        // Breaking Input
        //isBreaking = Input.GetKey(KeyCode.Space);
        isBreaking = Input.GetAxis("Jump");
        if(isBreaking > 0){ BreakingBool = true; }else{ BreakingBool = false; }
    }

    private void HandleMotor() {
        acceHandler = verticalInput * motorForce;
        if(acceHandler >= (maxAccelaration)){ //+50 niet nodig is gewoon ter controle //maxAccelaration kun je editen in de components
        rearLeftWheelCollider.motorTorque = verticalInput * motorForce;
        rearRightWheelCollider.motorTorque = verticalInput * motorForce;
        }else{
        rearLeftWheelCollider.motorTorque = maxAccelaration;
        rearRightWheelCollider.motorTorque = maxAccelaration;
        }



        //currentbreakForce = isBreaking ? breakForce : 0f;
        currentbreakForce = BreakingBool ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking() {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering() {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels() {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform) {
        Vector3 pos;
        Quaternion rot; 
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}