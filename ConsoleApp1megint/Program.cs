int[] lsz = new int[5];
int i  = 0, j  = 0;
char karakter  = ' ';
bool volt = true;
Random vsz = new Random();
Console.WriteLine("A lottoszámok: ");
do
{
    for (i = 0; i < 4; i++)
    {
        if (i > 0)
        {
            do
            {
                lsz[i] = vsz.Next(90) + 1;
                volt = false;
                for (j = 0; j < i; j++)
                    if (lsz[i] == lsz[j]) volt = true;
            } while (volt == true);
        }
        else lsz[i] = vsz.Next(90) + 1;
            Console.Write("{0, 5}", lsz[i]);
    }