using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCalculations : MonoBehaviour
{
    private Vector3 VectorA,VectorB;
    public int myScalaire = 3;

    void Start()
    {
        VectorA = new Vector3(1, 4, 8);
        VectorB = new Vector3(3, 0, 9);
        Debug.Log("On considère les deux vecteurs A (1,4,8) et vecteurs B (3,0,9) pour tous les calculs");
        Debug.Log("La magnitude du vecteur A est égale à :" + VectorA.magnitude);
        Debug.Log("La somme des deux vecteurs est égale à : " + (VectorA + VectorB));
        Debug.Log("La soustraction des deux vecteurs est égale à : " + (VectorA - VectorB));
        Debug.Log("La multiplication du vecteur A par le scalaire est égale à  : " + (VectorA*myScalaire));
        Debug.Log("Le produit scalaire des deux vecteurs est égal à : " + Vector3.Dot(VectorA,VectorB));
        Debug.Log("Le produit vectoriel des deux vecteurs est égal à : " + Vector3.Cross(VectorA,VectorB));
    }

}
