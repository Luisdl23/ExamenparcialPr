namespace ExamenparcialPr
{
    public class Libroselectronicos: Libro
    {
        public string Formato { get; set; }
        public int tamaniodelarchivo { get; set; }

        public Libroselectronicos()
        {
            Formato = string.Empty;
            tamaniodelarchivo = 0;        }

    }
}
