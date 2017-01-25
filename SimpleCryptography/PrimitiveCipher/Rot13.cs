namespace SimpleCryptography.PrimitiveCipher
{
    public class Rot13 :RotN, IRotate
    {
        public Rot13() : base(13) { }

        public new string Transform(string value)
        {
            return base.Transform(value);
        }
    }
}
