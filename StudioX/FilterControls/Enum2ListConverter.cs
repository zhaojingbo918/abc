using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StudioX
{
	public class Enum2ListConverter : IValueConverter
	{
		private static Enum2ListConverter m_Instance = new Enum2ListConverter();
		public static Enum2ListConverter Instance
		{
			get
			{
				return Enum2ListConverter.m_Instance;
			}
		}
		 
		private Enum2ListConverter()
		{
		}
		 
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Array list = Enum.GetValues((Type)value);
			List<string> stringList = new List<string>();
			foreach (object item in list)
			{
				stringList.Add(item.ToString());
			}
			return stringList;
		}
		 
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
		 
		
	}

}
