using UnityEngine;
using System.Collections;

public abstract class Ataque{

    protected float DmgRapida;
    protected float DmgLenta;

    protected float VariacionRapida;
    protected float VariacionLenta;

    protected float VelAtqRapida;   //TAMBIEN LA USA EL ATAQUE ESPECIAL
    protected float VelAtqLenta;    //TAMBIEN LA USA EL ATAQUE ESPECIAL

    private float ConsumoMana;
    private float Cooldown;


    //constructor publico para no leer en cada ataque que no sea especial el consumo de mana y el cooldown
    public Ataque()
    {
        ConsumoMana = 0;
        Cooldown = 0;
    }



    public float getVelAtqRapida()
    {
        return VelAtqRapida;
    }
    public void setVelAtqRapida(float velAtqRapida)
    {
        VelAtqRapida = velAtqRapida;
    }
    public float getVelAtqLenta()
    {
        return VelAtqLenta;
    }
    public void setVelAtqLenta(float velAtqLenta)
    {
        VelAtqLenta = velAtqLenta;
    }
    public float getDmgRapida()
    {
        return DmgRapida;
    }
    public void setDmgRapida(float dmgRapida)
    {
        DmgRapida = dmgRapida;
    }
    public float getDmgLenta()
    {
        return DmgLenta;
    }
    public void setDmgLenta(float dmgLenta)
    {
        DmgLenta = dmgLenta;
    }

    public float getVariacionRapida()
    {
        return VariacionRapida;
    }
    public void setVariacionRapida(float varRap)
    {
        VariacionRapida = varRap;
    }

    public float getVariacionLenta()
    {
        return VariacionLenta;
    }
    public void setVariacionLenta(float varLen)
    {
        VariacionLenta = varLen;
    }

    public float getConsumoMana()
    {
        return ConsumoMana;
    }
    public void setConsumoMana(float consumoMana)
    {
        ConsumoMana = consumoMana;
    }
    public float getCooldown()
    {
        return Cooldown;
    }
    public void setCooldown(float cooldown)
    {
        Cooldown = cooldown;
    }

}
