using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
	public class NewAttribute
	{
		private NewAttribute()
		{

		}

		public static readonly NewAttribute Intace = new NewAttribute();

		/// <summary>
		/// 1. out-variables(Out变量)
		/// </summary>
		/// <param name="result"></param>
		public void OutParams(out int result)
		{
			result = 0;
			result += 2;
		}

		/// <summary>
		/// 2.Tuples(元组)
		/// </summary>
		/// <returns></returns>
		public (string xm, string lL, string hanmm) GetFullName()
		{
			return ("小明", "李雷", "韩梅梅");
		}

		/// <summary>
		/// Pattern Matching(匹配模式)
		/// </summary>
		/// <returns></returns>
		public int PatternMatching()
		{
			object a = 1;
			int d = 0;
			if (a is int c)
			{
				 d = c + 10;
			}
			return d;
		}

		public dynamic PatternMatching(object a)
		{
			dynamic data;
			switch (a)
			{
				case int b:
					data = b++;
					break;
				case string c:
					data = c + "HelloWorld";
					break;
				default:
					data = null;
					break;
			}
			return data;
		}

		/// <summary>
		/// 4.ref locals and returns(局部变量和引用返回)
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public ref int GetByIndex(int[] arr, int index) => ref arr[index];

		public string IsNull(string str) => str ?? throw new Exception("字符串不能为空");
	}
}
