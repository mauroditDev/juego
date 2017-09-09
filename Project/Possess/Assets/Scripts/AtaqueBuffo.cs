using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AtaqueBuffo : Ataque {

    private int areaBuff;
    private int nombreBuffo;
    private float cantidadRaw;
    private float duracion;
    

    public int getNombreBuff()
    {
        return nombreBuffo;
    }
    public void setNombreBuff(int nombre)
    {
        nombreBuffo = nombre;
    }
    public int getAreaBuff()
    {
        return areaBuff;
    }
    public void setAreaBuff(int areaB)
    {
        areaBuff = areaB;
    }
    
    public void setCantidadRaw(float cantidad)
    {
        cantidadRaw = cantidad;
    }
    public float getCantidadRaw()
    {
        return cantidadRaw;
    }
    
    public void setDuracion(float dur)
    {
        duracion = dur;
    }
    public float getDuracion()
    {
        return this.duracion;
    }


}
