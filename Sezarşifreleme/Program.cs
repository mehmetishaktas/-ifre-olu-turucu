
int s1;
string cevir;
Random random = new Random();
for(int j=1;j<=20; j++)
{
    for(int i = 1; i <= 1; i++)
    {
         s1 = random.Next(40,96);
        cevir =Convert.ToString((char)s1);
        Console.Write(cevir);
       
    }           
}