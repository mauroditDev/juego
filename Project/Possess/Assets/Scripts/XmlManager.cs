using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System;

public class XmlManager{

    private int auxInt;
    private string auxString;
    private float auxFloat;

    public void leerBuffo(string nombre,Buffo objetivo)
    {
        XmlTextReader reader;
        reader = new XmlTextReader("./Assets/DB/Buffos/Buffos.xml");
        while (reader.ReadToFollowing("buffo"));
        if (reader.GetAttribute(0) == nombre)
        {
            reader.ReadToDescendant("atributo");
            objetivo.atributoAfectado = Tipos.valueOfBuffos(reader.ReadElementContentAsString());
            reader.ReadToFollowing("modo");
            objetivo.modoAplicacion = Tipos.valueOfBuffos(reader.ReadElementContentAsString());
            reader.ReadToFollowing("descripcion");
            objetivo.descripcion = reader.ReadElementContentAsString();
        }
    }

    public void leerPlayer(string nombre,Player jugador)
    {
        XmlTextReader reader;
        reader = new XmlTextReader("./Assets/DB/Jugador/PlayerStats.xml");
        while (reader.ReadToFollowing("player"))
        {
            if (reader.GetAttribute(0) == nombre)
            {
                reader.ReadToDescendant("cuerpo");
                auxString = reader.ReadElementContentAsString();
                jugador.setCurrentCuerpo(leerCuerpoPlayer(auxString));
                reader.ReadToFollowing("nivel");
                jugador.setNivel(reader.ReadElementContentAsInt());
                //TODO: leer el equipamiento con gilipoyez tipo jugador.setEquipamiento(reader.equipamiento);
                
            }
        }
    }

    public Cuerpo leerCuerpoPlayer(string cuerpo){
        XmlTextReader reader;
        reader = new XmlTextReader("./Assets/DB/Jugador/CuerposPlayer.xml");
        Cuerpo nuevoCuerpo;
        
        
        nuevoCuerpo = new Cuerpo();
        while (reader.ReadToFollowing("cuerpo"))
        {
            if (reader.GetAttribute(0) == cuerpo)
            {
                /*
                 * revisa esto:
                 * ***REVISADO Y ADAPTADO, A MI ME HA MOLADO****
                 */
                nuevoCuerpo.setTipoCuerpo(Tipos.valueOfCuerpos(cuerpo));

                reader.ReadToDescendant("nivel");
                nuevoCuerpo.setNivel(reader.ReadElementContentAsInt());
                reader.ReadToFollowing("mod_vida");
                nuevoCuerpo.setModVida(reader.ReadElementContentAsInt());
                reader.ReadToFollowing("mod_mana");
                nuevoCuerpo.setModMana(reader.ReadElementContentAsInt());
                reader.ReadToFollowing("velocidad_movimiento");
                nuevoCuerpo.setVelocidadMovimiento(reader.ReadElementContentAsFloat());

                /*
                 * CARGAR EL ATAQUE NORMAL
                 */

                reader.ReadToFollowing("ataque_normal");
                if (reader.GetAttribute(0) == "MELEE")
                {
                    AtaqueMelee nuevoAtaqueMelee;
                    nuevoAtaqueMelee = new AtaqueMelee();

                    /*
                     *RECOGE EL ATAQUE RAPIDO  
                     */
                    reader.ReadToDescendant("rapido");
                    nuevoAtaqueMelee.setArcoRapida(Tipos.valueOfArco(reader.GetAttribute(0)));
                    reader.ReadToDescendant("damage");
                    nuevoAtaqueMelee.setDmgRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("variacion");
                    nuevoAtaqueMelee.setVariacionRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("velocidad");
                    nuevoAtaqueMelee.setVelAtqRapida(reader.ReadElementContentAsFloat());

                    /*
                     *RECOGE EL ATAQUE LENTO
                     */
                    reader.ReadToFollowing("lento");
                    nuevoAtaqueMelee.setArcoLenta(Tipos.valueOfArco(reader.GetAttribute(0)));
                    reader.ReadToDescendant("damage");
                    nuevoAtaqueMelee.setDmgLenta(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("variacion");
                    nuevoAtaqueMelee.setVariacionLenta(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("velocidad");
                    nuevoAtaqueMelee.setVelAtqLenta(reader.ReadElementContentAsFloat());

                    //asignar el ataque
                    nuevoCuerpo.setAtaqueNormal(nuevoAtaqueMelee);
                }
                else
                {
                    AtaqueRanged nuevoAtaqueRanged;
                    nuevoAtaqueRanged = new AtaqueRanged();


                    /*
                     *RECOGE ATAQUE RAPIDO 
                     */
                    reader.ReadToDescendant("rapido");
                    nuevoAtaqueRanged.setTipoProyectil(Tipos.valueOfProyectil(reader.GetAttribute(0)));
                    nuevoAtaqueRanged.setVelTraslProyectil(float.Parse(reader.GetAttribute(1)));

                    reader.ReadToDescendant("damage");
                    nuevoAtaqueRanged.setDmgRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("variacion");
                    nuevoAtaqueRanged.setVariacionRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("velocidad");
                    nuevoAtaqueRanged.setVelAtqRapida(reader.ReadElementContentAsFloat());

                    /*
                     *RECOGE EL ATAQUE LENTO
                     */
                    reader.ReadToFollowing("lento");
                    nuevoAtaqueRanged.setTipoProyectil(Tipos.valueOfProyectil(reader.GetAttribute(0)));
                    nuevoAtaqueRanged.setVelTraslProyectil(float.Parse(reader.GetAttribute(1)));

                    reader.ReadToDescendant("damage");
                    nuevoAtaqueRanged.setDmgLenta(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("variacion");
                    nuevoAtaqueRanged.setVariacionLenta(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("velocidad");
                    nuevoAtaqueRanged.setVelAtqLenta(reader.ReadElementContentAsFloat());

                    //asigna el ataque
                    nuevoCuerpo.setAtaqueNormal(nuevoAtaqueRanged);
                }

                /*
                 * CARGAR EL ATAQUE ESPECIAL
                 */
                reader.ReadToFollowing("ataque_especial");
                if(reader.GetAttribute(0)=="MELEE")
                    //el ataque especial es MELEE
                {
                    AtaqueMelee nuevoAtaqueMelee;
                    nuevoAtaqueMelee = new AtaqueMelee();

                    //establece consumo de mana y cooldown
                    nuevoAtaqueMelee.setConsumoMana(float.Parse(reader.GetAttribute(1)));
                    nuevoAtaqueMelee.setCooldown(float.Parse(reader.GetAttribute(2)));

                    reader.ReadToDescendant("rapido");
                    nuevoAtaqueMelee.setArcoRapida(Tipos.valueOfArco(reader.GetAttribute(0)));
                    reader.ReadToDescendant("damage");
                    nuevoAtaqueMelee.setDmgRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("variacion");
                    nuevoAtaqueMelee.setVariacionRapida(reader.ReadElementContentAsFloat());
                    reader.ReadToFollowing("velocidad");
                    nuevoAtaqueMelee.setVelAtqRapida(reader.ReadElementContentAsFloat());

                    //asignar el ataque
                    nuevoCuerpo.setAtaqueEspecial(nuevoAtaqueMelee);
                }
                else
                {
                    if (reader.GetAttribute(0) == "RANGED")
                        //el ataque especial es RANGED
                    {
                        AtaqueRanged nuevoAtaqueRanged;
                        nuevoAtaqueRanged = new AtaqueRanged();

                        //establece consumo de mana y cooldown
                        nuevoAtaqueRanged.setConsumoMana(float.Parse(reader.GetAttribute(1)));
                        nuevoAtaqueRanged.setCooldown(float.Parse(reader.GetAttribute(2)));
                        
                        reader.ReadToDescendant("rapido");
                        nuevoAtaqueRanged.setTipoProyectil(Tipos.valueOfProyectil(reader.GetAttribute(0)));
                        nuevoAtaqueRanged.setVelTraslProyectil(float.Parse(reader.GetAttribute(1)));

                        reader.ReadToDescendant("damage");
                        nuevoAtaqueRanged.setDmgRapida(reader.ReadElementContentAsFloat());
                        reader.ReadToFollowing("variacion");
                        nuevoAtaqueRanged.setVariacionRapida(reader.ReadElementContentAsFloat());
                        reader.ReadToFollowing("velocidad");
                        nuevoAtaqueRanged.setVelAtqRapida(reader.ReadElementContentAsFloat());

                        //asigna el ataque
                        nuevoCuerpo.setAtaqueEspecial(nuevoAtaqueRanged);
                    }
                    else
                        //el ataque especial es BUFFO
                    {
                        AtaqueBuffo nuevoAtaqueBuffo;
                        nuevoAtaqueBuffo = new AtaqueBuffo();

                        //establece consumo de mana y cooldown
                        nuevoAtaqueBuffo.setConsumoMana(float.Parse(reader.GetAttribute(1)));
                        nuevoAtaqueBuffo.setCooldown(float.Parse(reader.GetAttribute(2)));

                        reader.ReadToDescendant("area");
                        nuevoAtaqueBuffo.setAreaBuff(Tipos.valueOfArea(reader.ReadElementContentAsString()));
                        reader.ReadToFollowing("buffo");
                        nuevoAtaqueBuffo.setNombreBuff(int.Parse(reader.GetAttribute(0)));
                        nuevoAtaqueBuffo.setDuracion(int.Parse(reader.GetAttribute(1)));
                        nuevoAtaqueBuffo.setCantidadRaw(reader.ReadElementContentAsFloat());

                        //asigna el ataque
                        nuevoCuerpo.setAtaqueEspecial(nuevoAtaqueBuffo);

                    }
                }
            }
        }
        return nuevoCuerpo;
    }
}
