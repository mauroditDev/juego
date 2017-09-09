using System;

public static class Tipos
{
    /// <summary>
    /// 
    /// </summary>
	public enum TIPO_MUNDO { WOODS, DUNGEON, CUEVA, CASTILLO, INFIERNO };

    public enum TIPO_POSICIONES { EN_PEQ, EN_GRANDE, BOSS, COFRE, TEMPLO };

    public enum TIPO_ESTADOS { MUERTO, IDLE, MOVIMIENTO, DODGE, BLOCK, ATQ_LENTO, ATQ_RAPIDO, SPECIAL };

    public enum TIPO_CUERPO_COFRE
    {
        COFRE_COMUN,
        COFRE_RARE,
        COFRE_LEGENDARY,
        COFRE_EPIC,
        COFRE_TRAMPA,
        COFRE_SURPRISE
    }

    public enum TIPO_CUERPO_TEMPLO
    {
        FUENTE_MANA,
        FUENTE_VIDA,
        TEMPLO_BUFF,
        TEMPLO_DEBUFF
    }

    public enum TIPO_CUERPO_PLAYER
    {
        BASICO,         // MELEE / MELEE (EQUIVALE A WARRIOR_01)
        ROGUE_01,       // MELEE / RANGED
        CLERIC_01,      // MELEE / BUFFO
        ARCHER_01,      // RANGED / MELEE
        MAGE_01,        // RANGED / RANGED
        WIZARD_01,      // RANGED / BUFFO
        WARRIOR_02
    }

    public enum TIPO_CUERPO_ENEMIGO
    {
        GOBLIN_,
        ANIMAL_,
        DEMON_,
        HUMAN_,
        ORCO_,
        UNDEAD_
    }

    public enum TIPO_EQUIPAMIENTO
    {
        ANILLO_,
        AMULETO_,
        TALISMAN_
    }

    public enum TIPO_ARCO
    {
        BASICO,
        LARGO_1,
        LARGO_2,
        CORTO_ANCHO_1,
        CORTO_ANGOSTO_1
    }

    public enum TIPO_PROYECTIL
    {
        FLECHA,
        ONDA,
        ONDA_GRANDE
    }

    public enum TIPO_BUFFO
    {
        MOVIMIENTO,
        DAMAGE,
        VARIACION,
        VEL_ATAQUE
    }

    public enum TIPO_AREA
    {
        AREA_BIG_01,
        AREA_SMALL_01,
        AREA_LONG_01
    }

    public enum TIPO_APLICACION_BUFFO
    {
        MULTIPLICADOR,
        SUMA
    }

    public static int valueOfCuerpos(string tipo)
    {
        foreach(int value in Enum.GetValues(typeof(TIPO_CUERPO_PLAYER))){
            if(value.ToString().Equals(tipo)){
                return value;
            }
        }
        return -1;
    }

    public static int valueOfArco(string tipo)
    {
        foreach (int value in Enum.GetValues(typeof(TIPO_ARCO)))
        {
            if (value.ToString().Equals(tipo))
            {
                return value;
            }
        }
        return -1;
    }

    public static int valueOfProyectil(string tipo)
    {
        foreach (int value in Enum.GetValues(typeof(TIPO_PROYECTIL)))
        {
            if (value.ToString().Equals(tipo))
            {
                return value;
            }
        }
        return -1;
    }

    public static int valueOfBuffos(string tipo)
    {
        foreach (int value in Enum.GetValues(typeof(TIPO_BUFFO)))
        {
            if (value.ToString().Equals(tipo))
            {
                return value;
            }
        }
        return -1;
    }

    public static int valueOfApBuff(string tipo)
    {
        foreach (int value in Enum.GetValues(typeof(TIPO_APLICACION_BUFFO)))
        {
            if (value.ToString().Equals(tipo))
            {
                return value;
            }
        }
        return -1;
    }

    public static int valueOfArea(string tipo)
    {
        foreach (int value in Enum.GetValues(typeof(TIPO_AREA)))
        {
            if (value.ToString().Equals(tipo))
            {
                return value;
            }
        }
        return -1;
    }

}
