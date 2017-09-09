using UnityEngine;
using System.Collections;

public class AtaqueMelee : Ataque {

    private int ArcoRapida;
    private int ArcoLenta;

    public AtaqueMelee()
    {
        DmgRapida = 1;
        DmgLenta = 1;

        VelAtqRapida = 1;
        VelAtqLenta = 1;

        ArcoLenta = 0;
        ArcoRapida = 0;

    }

    public int getArcoRapida()
    {
        return ArcoRapida;
    }
    public void setArcoRapida(int arcoRapida)
    {
        ArcoRapida = arcoRapida;
    }
    public int getArcoLenta()
    {
        return ArcoLenta;
    }
    public void setArcoLenta(int arcoLenta)
    {
        ArcoLenta = arcoLenta;
    }
	
}
