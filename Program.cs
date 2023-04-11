Console.WriteLine("Введите число");
int M =int.Parse(Console.ReadLine());

int Numbers()
{
  if(M<1)
  {
    return M;
  }
     Console.Write(M+" ");
    M--;
    return Numbers();
}

Numbers();