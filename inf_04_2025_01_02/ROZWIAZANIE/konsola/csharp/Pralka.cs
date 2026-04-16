class Pralka : Urzadzenie
{
    private int nrProgramu = 0;

    public int Ustaw_nr_prania(int program)
    {
        if (program < 1 || program > 12)
        {
            nrProgramu = 0;
        }
        else
        {
            nrProgramu = program;
        }
        return nrProgramu;
    }
}