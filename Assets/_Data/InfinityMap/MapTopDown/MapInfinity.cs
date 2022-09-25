using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInfinity : MonoBehaviour
{
    public MapInfinity mapTop;
    public MapInfinity mapTopRight;
    public MapInfinity mapTopLeft;
    public MapInfinity mapLeft;
    public MapInfinity mapRight;
    public MapInfinity mapButton;
    public MapInfinity mapButtonRight;
    public MapInfinity mapButtonLeft;

    public virtual MapInfinity Get(MapCode mapCode)
    {
        switch (mapCode)
        {
            case MapCode.mapTop:
                return this.mapTop;
            case MapCode.mapTopRight:
                return this.mapTopRight;
            case MapCode.mapTopLeft:
                return this.mapTopLeft;
            case MapCode.mapLeft:
                return this.mapLeft;
            case MapCode.mapRight:
                return this.mapRight;
            case MapCode.mapBottom:
                return this.mapButton;
            case MapCode.mapBottomRight:
                return this.mapButtonRight;
            case MapCode.mapBottomLeft:
                return this.mapButtonLeft;
        }

        return null;
    }

    public virtual void Set(MapCode mapCode, MapInfinity newMap)
    {
        switch (mapCode)
        {
            case MapCode.mapTop:
                this.mapTop = newMap;
                break;
            case MapCode.mapTopRight:
                this.mapTopRight = newMap;
                break;
            case MapCode.mapLeft:
                this.mapLeft = newMap;
                break;
            case MapCode.mapRight:
                this.mapRight = newMap;
                break;
            case MapCode.mapBottom:
                this.mapButton = newMap;
                break;
            case MapCode.mapBottomRight:
                this.mapButtonRight = newMap;
                break;
            case MapCode.mapBottomLeft:
                this.mapButtonLeft = newMap;
                break;
        }
    }
}
