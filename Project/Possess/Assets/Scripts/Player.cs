using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour {

    private int currentVida;
    private int CurrentMana;
    private Cuerpo CurrentCuerpo;
    private List<Equipamiento> EquipamientoList;
    private Vector3 Posicion;
    private int CurrentEstadoPlayer;
    private int Nivel;

    private Rigidbody currentArco;


    public void setCurrentArco(Rigidbody arco)
    {
        currentArco = arco;
    }

    public Rigidbody getCurrentArco()
    {
        return currentArco;
    }

    

    private CharacterController controller;

    public void setController()
    {
        this.controller = GetComponent<CharacterController>();
    }

    public CharacterController getPlayerController()
    {
        return controller;
    }

    public int getCurrentVida()
    {
        return currentVida;
    }
    public void setCurrentVida(int currentVida)
    {
        this.currentVida = currentVida;
    }
    public int getCurrentMana()
    {
        return CurrentMana;
    }
    public void setCurrentMana(int currentMana)
    {
        CurrentMana = currentMana;
    }
    public Cuerpo getCurrentCuerpo()
    {
        return CurrentCuerpo;
    }
    public void setCurrentCuerpo(Cuerpo currentCuerpo)
    {
        CurrentCuerpo = currentCuerpo;
    }
    public List<Equipamiento> getEquipado()
    {
        return EquipamientoList;
    }
    public void setEquipado(Equipamiento equipado,int posicion)
    {
        EquipamientoList.Insert(posicion, equipado);
    }
    public Vector3 getPosicion()
    {
        return Posicion;
    }
    public void setPosicion(Vector3 posicion)
    {
        Posicion = posicion;
    }
    public int getCurrentEstadoPlayer()
    {
        return CurrentEstadoPlayer;
    }
    public void setCurrentEstadoPlayer(int currentEstadoPlayer)
    {
        CurrentEstadoPlayer = currentEstadoPlayer;
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
