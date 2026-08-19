using System.IO;
class Alfabet
{
    FileStream F;
    char[] alfabet = {  'A',  'B', 'C',  'D', 'E',  'F', 'G', 'H', 'I', 'J', 'K', 'L',  'M', 'N',  'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    public void zapisz_i_odczytaj_dane()
    {
        F = new FileStream("Litery.txt", FileMode.Create);
        for( int i =0; i < alfabet.Length; i++)
        {
            F.WriteByte((byte)alfabet[i]);
        }
        F.Close();
        F= new FileStream("Litery.txt", FileMode.Open);
        //for (int i = 0; i < alfabet.Length; i++)
        //{
            F.Seek(5, SeekOrigin.Begin);

            Console.Write((char)F.ReadByte());
            Console.Write(", ");
            F.Seek(3, SeekOrigin.Current);
        Console.Write((char)F.ReadByte());
       
        Console.Write(", ");
        F.Seek(-2, SeekOrigin.End);
        Console.Write((char)F.ReadByte());
        Console.Write(". ");

        /*if ( i < alfabet.Length - 1)
        {
            Console.Write(", ");
        } else
        {
            Console.WriteLine(".");
        } */

        //Console.Write(alfabet[i]);
        //}
        F.Close();
    }
         
        
    






    static void Main(String[] args)
    {
        Alfabet alfabet = new Alfabet();
        alfabet.zapisz_i_odczytaj_dane();



    }
}