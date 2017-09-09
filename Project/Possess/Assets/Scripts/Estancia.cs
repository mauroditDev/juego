using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Estancia : MonoBehaviour {

    private int TipoMundo;
    private int CantMaxEnemigos;
    private int CurrentEnemigos;
    private int MaxCaminos;
    private int MinCaminos;
    private List<PosicionesEstancia> PosicionesDestacadasList;


    public int getTipoMundo()
    {
        return TipoMundo;
    }

    public void setTipoMundo(int tipoMundo) 
    {
        this.TipoMundo = tipoMundo;
    }

    public int getCantMaxEnemigos()
    {
        return CantMaxEnemigos;
    }

    public void setCantMaxEnemigos(int cantMax)
    {
        this.CantMaxEnemigos = cantMax;
    }

    public int getCurrentEnemigos()
    {
        return CurrentEnemigos;
    }

    public void setCurrentEnemigos(int currentEnemigos)
    {
        this.CurrentEnemigos = currentEnemigos;
    }

    public int getMaxCaminos()
    {
        return MaxCaminos;
    }

    public void setMaxCaminos(int maxCaminos)
    {
        this.MaxCaminos = maxCaminos;
    }

    public int getMinCaminos()
    {
        return MinCaminos;
    }
    public void setMinCaminos(int minCaminos)
    {
        MinCaminos = minCaminos;
    }

    public List<PosicionesEstancia> getPosicionesDestacadasList()
    {
        return PosicionesDestacadasList;
    }

    public void setPosicionesDestacadasList(List<PosicionesEstancia> posicionesDestacadasList)
    {
        PosicionesDestacadasList = posicionesDestacadasList;
    }
}
