using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private PlayerManager currentPlayerManager;
    private Player jugador;

	void Start(){
        currentPlayerManager = this.GetComponent<PlayerManager>();
        currentPlayerManager.inicializar();
        jugador = currentPlayerManager.getPlayerActual();
        XmlManager xmlManager = new XmlManager();
        xmlManager.leerPlayer("juasjuas",jugador);
        Debug.Log(jugador.getNivel());
        Debug.Log(jugador.getCurrentCuerpo().getAtaqueNormal().getDmgRapida());
        Debug.Log(jugador.getCurrentCuerpo().getAtaqueNormal().getDmgLenta());
        Debug.Log(jugador.getCurrentCuerpo().getAtaqueEspecial().getConsumoMana());
    }
	
}
