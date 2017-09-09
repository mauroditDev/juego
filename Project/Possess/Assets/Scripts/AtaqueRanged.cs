using UnityEngine;
using System.Collections;

public class AtaqueRanged : Ataque {


    private int tipoProyectil;
    private float velTraslProyectil;


    public int getTipoProyectil()
    {
        return tipoProyectil;
    }

    public void setTipoProyectil(int tipoProyectil)
    {
        this.tipoProyectil = tipoProyectil;
    }

    public float getVelTraslProyectil()
    {
        return velTraslProyectil;
    }

    public void setVelTraslProyectil(float velTraslProyectil)
    {
        this.velTraslProyectil = velTraslProyectil;
    }


}
