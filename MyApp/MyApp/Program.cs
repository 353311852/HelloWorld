using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region C#7.0新特性
			NewAttribute.Intace.OutParams(out int result);
			var (xm, lL, hanmm) = NewAttribute.Intace.GetFullName();
			object a = "1";
			dynamic res = NewAttribute.Intace.PatternMatching(a);
			int[] arr = new int[] { 1, 2, 3, 4, 5 };
			ref int b =ref NewAttribute.Intace.GetByIndex(arr, 1);
			//C#7.0异常处理机制
			NewAttribute.Intace.IsNull("");
			#endregion
		}
	}
}
