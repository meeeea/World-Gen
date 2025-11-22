using System.Drawing;

class Point: IConvertible
{
    public int value;
    public double scale = 1;
    private int? x;
    private int? y ;


    private int cvalue => Math.Max(Math.Min(value, 255), 0);
    public static implicit operator int(Point point) => point.value;
    public static implicit operator Color(Point point)
    {
        if (point.x is not null && point.y is not null)
        {
            return Color.FromArgb((int) point.x, (int) point.y, point.cvalue);
        }
        
        return Color.FromArgb(point.cvalue, point.cvalue, point.cvalue);
    } 
    public static implicit operator float(Point point) => ((float) point.value / (float) 255) * (float) point.scale;
    public Point()
    {
        value = Rand.Random(0, 255);
    }



    public Point(double height)
    {
        value = (int)Math.Floor(255 * height);
        value = cvalue;
    }
    
    public Point(double height, double scale)
    {
        value = (int)Math.Floor(255 * height / scale);
        this.scale = scale;
        value = cvalue;
    }

    public Point(double height, double X, double Y)
    {
        value = (int)Math.Floor(255 * height);
        value = cvalue;
        x = (int)Math.Floor(255 * X);
        y = (int)Math.Floor(255 * Y);
    }
    public override string ToString()
    {
        return $"{(float) this}";
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