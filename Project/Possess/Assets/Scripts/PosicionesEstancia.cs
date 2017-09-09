using UnityEngine;
using System.Collections;

public class PosicionesEstancia : MonoBehaviour {

    public Vector3 Coordenadas;
    public int TipoPosicion;

    public Vector3 getCoordenadas()
    {
        return this.Coordenadas;
    }

    public void setCoordenadas(float x,float y, float z)
    {
        this.Coordenadas = new Vector3(x, y, z);
    }

    public int getTipo()
    {
        return this.TipoPosicion;
    }

    public void setTipo(int t)
    {
        this.TipoPosicion = t;
    }

}
