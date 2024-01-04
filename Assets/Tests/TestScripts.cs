using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Tests
{

    // A Test behaves as an ordinary method
    [Test]
    public void InicializacionValores() // CaidaPiezas
    {
        //Arrange
        // CaidaPiezas c = new CaidaPiezas();
        GameObject testObject = new GameObject();
        CaidaPiezas c = testObject.AddComponent<CaidaPiezas>();

        //Act
        bool isTouchingFloor = c.get_isTouchingFloor();
        bool isTouchingWall = c.get_isTouchingWall();

        //Assert
        Assert.AreEqual(isTouchingFloor, false);
        Assert.AreEqual(isTouchingWall, false);
    }
    [Test]
    public void SettersValores() // CaidaPiezas
    {
        //Arrange
        // CaidaPiezas c = new CaidaPiezas();
        GameObject testObject = new GameObject();
        CaidaPiezas c = testObject.AddComponent<CaidaPiezas>();

        //Act
        c.setisTouchingFloor(true);
        bool isTouchingFloor = c.get_isTouchingFloor();
        bool isTouchingWall = c.get_isTouchingWall();

        //Assert
        Assert.AreEqual(isTouchingFloor, true);
        Assert.AreEqual(isTouchingWall, false);
    }
    
    [Test]
    public void Vector3DentroZona() // SpawnerPiezas
    {
        //Arrange
        GameObject testObject = new GameObject();
        SpawnerPiezas s = testObject.AddComponent<SpawnerPiezas>();

        //Act
        Vector3 vector3 = s.newSpawnPosition();

        // Debug.Log(vector3.x);
        // Debug.Log(vector3.y);
        // Debug.Log(vector3.z);

        //Assert

        Assert.IsTrue(vector3.x <= 10); 
        Assert.IsTrue(vector3.y <= s.ALTURA);
        Assert.IsTrue(vector3.z <= 30);
    }

    [Test]
    public void QuaternionDentroZona() // SpawnerPiezas
    {
        //Arrange
        GameObject testObject = new GameObject();
        SpawnerPiezas s = testObject.AddComponent<SpawnerPiezas>();

        //Act
        Quaternion q = s.newSpawnRotation();

        float rotationX = q.eulerAngles.x;
        float rotationY = q.eulerAngles.y;
        float rotationZ = q.eulerAngles.z;
        
        // Debug.Log(rotationX);
        // Debug.Log(rotationY);
        // Debug.Log(rotationZ);

        //Assert
        Assert.IsTrue(rotationX <= 360);
        Assert.IsTrue(rotationY <= 360);
        Assert.IsTrue(rotationZ <= 360);
    }
    
    [Test]
    public void CambioDeVolumen() // Volumen
    {
        //Arrange
        GameObject testObject = new GameObject();
        Volumen v = testObject.AddComponent<Volumen>();

        var volumen = AudioListener.volume;
        Debug.Log(volumen);
        if (volumen != 0.5f)
        {
            Assert.AreNotEqual(volumen, 0.5f);
            v.CambiarVolumen(0.5f);
        }
        volumen = AudioListener.volume;
        Assert.AreEqual(0.5f, volumen);
    }

}