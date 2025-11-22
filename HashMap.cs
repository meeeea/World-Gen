using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class HashMap<T> : IConvertible
    where T : IConvertible, new()
{
    private List<List<T>> hashmap = new();

    private int scaleX;
    public int Width => scaleX;
    private int scaleY;
    public int Height => scaleY;
    public HashMap(int width = 160, int height = 90)
    {
        scaleX = width;
        scaleY = height;
        for (int i = 0; i < width; i++)
        {
            hashmap.Add(new());
            for (int k = 0; k < height; k++)
            {
                hashmap[i].Add(new());
            }
        }
    }

    public T GetPoint(int x, int y)
    {
        return hashmap[x][y];
    }

    public Color GetPointHue(int x, int y)
    {
        return (Color)Convert.ChangeType(hashmap[x][y], typeof(Color));
    }


// after here is ICONVERTER stuff and therefor unnecisary
    public TypeCode GetTypeCode()
    {
        throw new NotImplementedException();
    }

    public bool ToBoolean(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public byte ToByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public char ToChar(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public DateTime ToDateTime(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public decimal ToDecimal(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public double ToDouble(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public short ToInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public int ToInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public long ToInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public sbyte ToSByte(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public float ToSingle(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public string ToString(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public object ToType(Type conversionType, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public ushort ToUInt16(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public uint ToUInt32(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public ulong ToUInt64(IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }
}