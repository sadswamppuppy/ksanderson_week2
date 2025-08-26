namespace ksanderson_week2.Services
{
	public class Calculator : ICalculator
	{
		public int Add(int x, int y) => x + y;
		public int Subtract(int x, int y) => x - y;
	}
}
