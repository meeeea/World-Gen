using System.Security.Cryptography.X509Certificates;
using System.Drawing;

class Vec2: IConvertible
{
    private double X;
    private double Y;
    public double x => X;
    public double y => Y;

    public static implicit operator Color(Vec2 vec2) => Color.FromArgb((int) Math.Floor(255 * vec2.x), (int) Math.Floor(255 * vec2.x), 0);
    public Vec2 ()
    {
        X = Rand.Random();
        Y = Rand.Random();
    }

    public Vec2(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({Math.Round(x, 5)}, {Math.Round(y, 5)})";
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
        return (Color) this;
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