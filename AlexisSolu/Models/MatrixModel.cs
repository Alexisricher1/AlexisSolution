namespace AlexisSolu.Models
{
    public class MatrixModel
    {
        public MatrixModel(int pSize, MatrixModelBase pBase)
        {
            Size = pSize;
            Base = pBase;
        }

        public int Size { get; set; }

        public MatrixModelBase Base { get; set; }

        public enum MatrixModelBase
        {
            Decimal = 0,
            Binary,
            Hexadecimal
        }
    }
}