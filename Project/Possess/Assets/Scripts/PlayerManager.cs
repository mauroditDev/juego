using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour {

    private Player playerActual; //Player
    private List<Equipamiento> inventario; //Equipamiento
    public Rigidbody[] currentAtaque; //0:AtaqueRapido 1:AtaqueLento 2: AtaqueEspecial
    //TODO : Lee el input y gestiona estados del player

    public GameObject prefabA;

    public Player getPlayerActual()
    {
        return playerActual;
    }
    public void setPlayerActual(Player playerActual)
    {
        this.playerActual = playerActual;
    }
    public List<Equipamiento> getInventario()
    {
        return inventario;
    }
    public void setInventario(List<Equipamiento> inventario)
    {
        this.inventario = inventario;
    }
    public void setCurrentAtaque(Rigidbody atRa, Rigidbody atLen, Rigidbody atEsp)
    {
        currentAtaque = new Rigidbody[3];
        currentAtaque[0] = atRa;
        currentAtaque[1] = atLen;
        currentAtaque[2] = atEsp;

    }


    public void movPlayer(float axisX, float axisY)
    {

        Vector3 direccion = new Vector3(axisX, 0, axisY);
        
        
        
        direccion *= getPlayerActual().getCurrentCuerpo().getVelocidadMovimiento();

        getPlayerActual().getPlayerController().Move(direccion);

        if (direccion != Vector3.zero)
        {
            getPlayerActual().transform.rotation = Quaternion.LookRotation(direccion);
        }
        
    }

    public void inicializar()
    {
        GameObject playerObject = (GameObject)Instantiate(prefabA, Vector3.zero, Quaternion.identity);
        setPlayerActual(playerObject.GetComponent<Player>());
        getPlayerActual().setController();
        getPlayerActual().setCurrentEstadoPlayer((int)Tipos.TIPO_ESTADOS.IDLE);
        getPlayerActual().setCurrentCuerpo(new Cuerpo());
    }

	// Update is called once per frame
	void Update () {
        
        if (getPlayerActual().getCurrentEstadoPlayer() == (int)Tipos.TIPO_ESTADOS.IDLE 
            || getPlayerActual().getCurrentEstadoPlayer() == (int)Tipos.TIPO_ESTADOS.MOVIMIENTO)
        {
            //Leer input
            if (Input.GetButtonDown("Fire1"))
            {
                //ataque rapido
                //TODO llamar animacion
                ataqueRapido();
                //TODO calcular colision
                //TODO calcular daños y comunicarlo
            }
            else
            {
                //moviendote
                movPlayer(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
            }
        }
    }

    void restablecerEstado(){
        getPlayerActual().setCurrentEstadoPlayer((int)Tipos.TIPO_ESTADOS.IDLE);
        Destroy(getPlayerActual().getCurrentArco().gameObject);
    }

    private void ataqueRapido()
    {
        getPlayerActual().setCurrentEstadoPlayer((int)Tipos.TIPO_ESTADOS.ATQ_RAPIDO);
        getPlayerActual().setCurrentArco((Rigidbody)Instantiate(currentAtaque[0], getPlayerActual().transform.position, getPlayerActual().transform.rotation));
        Invoke("restablecerEstado", getPlayerActual().getCurrentCuerpo().getAtaqueNormal().getVelAtqRapida());
    }

}
