using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cuerpo{

    private Ataque ataqueNormal;//Ataque
    private int tipoCuerpo;
    private int nivel;
    private Ataque ataqueEspecial;//Ataque
    private float modVida;
    private float modMana;
    private float velocidadMovimiento;
    private List<AudioClip> sonidosList;
    private List<Buffo> currentBuffos;

    public Cuerpo()
    {
        setAtaqueNormal(new AtaqueMelee());
        velocidadMovimiento = 2;
    }

    public List<AudioClip> getSonidosList()
    {
        return sonidosList;
    }
    public void setSonidosList(List<AudioClip> sonidosList)
    {
        this.sonidosList = sonidosList;
    }

    public Ataque getAtaqueNormal()
    {
        return ataqueNormal;
    }
    public void setAtaqueNormal(Ataque ataqueN)
    {
        this.ataqueNormal = ataqueN;
    }
    public int getTipoCuerpo()
    {
        return tipoCuerpo;
    }
    public void setTipoCuerpo(int tipoC)
    {
        this.tipoCuerpo = tipoC;
    }
    public int getNivel()
    {
        return nivel;
    }
    public void setNivel(int nivel)
    {
        this.nivel = nivel;
    }
    public Ataque getAtaqueEspecial()
    {
        return ataqueEspecial;
    }
    public void setAtaqueEspecial(Ataque ataqueE)
    {
        ataqueEspecial = ataqueE;
    }
    public float getModVida()
    {
        return modVida;
    }
    public void setModVida(float modV)
    {
        modVida = modV;
    }
    public float getModMana()
    {
        return modMana;
    }
    public void setModMana(float modM)
    {
        modMana = modM;
    }
    public float getVelocidadMovimiento()
    {
        return velocidadMovimiento;
    }
    public void setVelocidadMovimiento(float velocidadM)
    {
        velocidadMovimiento = velocidadM;
    }


}
