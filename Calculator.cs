class Calculator
{
	static void main(string[]args)
	{
		int a = 10;
		int b = 6;
		Console.WriteLine("hasil penambahan;{1} + {1} = {2}",a ,b,penambahan(a, b));
		Console.WriteLine("hasil pengurangan: {0} - {1} = {1}", a, b,pengurangan(a ,b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	static inr penambahan (int a,int b)
	{
		return a+b;
	}
	static int pengurangan(int a,int b)
	{
		return a-b;
	}
}