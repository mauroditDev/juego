using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mundo : MonoBehaviour {
    /*
     * 
     World
- Tipo : Enum (Infierno, Mazmorra, etc)
- Escenario : List(Estancia)
- SonidoAmbientoe : Sound
+ generadorNivel(int lvlPlayer)
+ gets y sets
+ playSound(SonidoAmbiente)
* 
     * 
     */
    public int TipoMundo;
    public List<Estancia> Escenario;
    public AudioClip SonidoAmbiente;

    public void setTipo(int t)
    {
        this.TipoMundo = t;
    }

    public int getTipoMundo()
    {
        return TipoMundo;
    }

    public void setTipoMundo(int tipoMundo)
    {
        TipoMundo = tipoMundo;
    }
    public List<Estancia> getEscenario()
    {
        return Escenario;
    }
    public void setEscenario(List<Estancia> escenario)
    {
        Escenario = escenario;
    }
    public AudioClip getSonidoAmbiente()
    {
        return SonidoAmbiente;
    }
    public void setSonidoAmbiente(AudioClip sonidoAmbiente)
    {
        SonidoAmbiente = sonidoAmbiente;
    }

}
