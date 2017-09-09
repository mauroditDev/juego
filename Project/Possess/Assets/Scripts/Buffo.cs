using UnityEngine;
using System.Collections;
using System;

public class Buffo: MonoBehaviour{

    public float duracionRestante;
    public int nombreBuff;
    public int atributoAfectado;
    public float cantidadRaw;
    public int modoAplicacion;//define que metodo aplica al buff (aumento lineal,aumento porcentual,disminucion...)
    public string descripcion;

    public void inicializar(int nombre) //inicializa el buffo dado el nombre
    {
        XmlManager xmlManager = new XmlManager();
        xmlManager.leerBuffo(Enum.GetName(typeof(Tipos.TIPO_BUFFO),nombre),this);

    }

    void Update()   //verifica que el buffo no haya excedido la duracion y lo destruye si así es
    {
        if(duracionRestante != -1)  //reserva el -1 para los buffos permanentes
        {
            duracionRestante = duracionRestante - Time.deltaTime;
            if (duracionRestante < 0)
            {
                Destroy(this);
            }
        }
        
    }

}
