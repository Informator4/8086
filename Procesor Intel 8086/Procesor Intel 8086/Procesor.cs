public class Procesor
{
    // Rejestry
    public short AX = 0;
    public short BX = 0;
    public short CX = 0;
    public short DX = 0;

    Program program = new Program();

    public short getAX()
    {
        return AX;
    }
    public short getBX()
    {
        return BX;
    }
    public short getCX()
    {
        return CX;
    }
    public short getDX()
    {
        return DX;
    }
}