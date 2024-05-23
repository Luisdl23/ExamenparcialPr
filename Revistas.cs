namespace ExamenparcialPr
{
    public class Revistas : Libro
    {
        public int Volumen { get; set; }
        public int Numeroejemplar { get; set; }

        public Revistas()
        {
            Volumen = 0;
            Numeroejemplar = 0;
        }

    }
}
