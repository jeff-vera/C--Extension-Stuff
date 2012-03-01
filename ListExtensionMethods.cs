using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionFun
{
	public static class ListExtensionMethods
	{
		public static List<T> Paginate<T>
			(this List<T> list)
		{
			return list;
		}
	}
}
