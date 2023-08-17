using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Utils {
	public static class BindProperty {
		public static string resolve(object property, string propertyName) {
				string retValue = "";
				if (propertyName.Contains(".")) {
					PropertyInfo[] arrayProperties;
					string leftPropertyName;
					leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
					arrayProperties = property.GetType().GetProperties();

					foreach (PropertyInfo propertyInfo in arrayProperties) {
						if (propertyInfo.Name == leftPropertyName) {
							retValue = BindProperty.resolve(
													  propertyInfo.GetValue(property, null),
													  propertyName.Substring(propertyName.IndexOf(".") + 1)
													);
							break;
						}
					}
				} else {
					Type propertyType;
					PropertyInfo propertyInfo;
					propertyType = property.GetType();
					propertyInfo = propertyType.GetProperty(propertyName);
					retValue = propertyInfo.GetValue(property, null).ToString();
				}
				return retValue;
			}
	}
}
