using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    private int CurrentVida;
    private Cuerpo TipoEnemigo;
    private int Posicion;
    private int CurrentEstado;
    private float DificultadPosesion;
    private int Experiencia;
    private int NivelDrop;
    private int Nivel;
    private double SpotDistance;
    private double AtkDistance;
    // TODO: implementar IA

    public int getCurrentVida()
    {
        return CurrentVida;
    }
    public void setCurrentVida(int currentVida)
    {
        CurrentVida = currentVida;
    }
    public Cuerpo getTipoEnemigo()
    {
        return TipoEnemigo;
    }
    public void setTipoEnemigo(Cuerpo tipoEnemigo)
    {
        TipoEnemigo = tipoEnemigo;
    }
    public int getPosicion()
    {
        return Posicion;
    }
    public void setPosicion(int posicion)
    {
        Posicion = posicion;
    }
    public int getCurrentEstado()
    {
        return CurrentEstado;
    }
    public void setCurrentEstado(int currentEstado)
    {
        CurrentEstado = currentEstado;
    }
    public float getDificultadPosesion()
    {
        return DificultadPosesion;
    }
    public void setDificultadPosesion(float dificultadPosesion)
    {
        DificultadPosesion = dificultadPosesion;
    }
    public int getExperiencia()
    {
        return Experiencia;
    }
    public void setExperiencia(int experiencia)
    {
        Experiencia = experiencia;
    }
    public int getNivelDrop()
    {
        return NivelDrop;
    }
    public void setNivelDrop(int nivelDrop)
    {
        NivelDrop = nivelDrop;
    }
    public int getNivel()
    {
        return Nivel;
    }
    public void setNivel(int nivel)
    {
        Nivel = nivel;
    }

}
