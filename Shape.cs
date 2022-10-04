//User defined type

class Shape
{
   internal string Name { get; set; } = ""; //data member
   internal string Scramble(bool unique)
    {
        Random rand = new Random();
        char[] scramble = Name.ToArray();
        for (int i = 0; i < this.Name.Length; i++)
        {
            scramble[i] = scramble[rand.Next(scramble.Length)];
        }
        return new String(scramble);
    }
}