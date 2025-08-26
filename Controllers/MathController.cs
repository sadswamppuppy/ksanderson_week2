using Microsoft.AspNetCore.Mvc;
using ksanderson_week2.Services;

namespace ksanderson_week2.Controllers
{
	[ApiController]
	[Route("math")]
	public class MathController : ControllerBase
	{
		private readonly ICalculator _calculator;

		public MathController(ICalculator calculator)
		{
			_calculator = calculator;
		}

		[HttpGet("add")]
		public IActionResult Add(int a, int b)
		{
			var result = _calculator.Add(a, b);
			return Ok(new { a, b, result });
		}

		[HttpGet("subtract")]
		public IActionResult Subtract(int a, int b)
		{
			var result = _calculator.Subtract(a, b);
			return Ok(new { a, b, result });
		}
	}
}
