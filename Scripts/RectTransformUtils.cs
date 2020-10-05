using System.Reflection;
using UnityEngine;

namespace Kogane
{
	public static class RectTransformUtils
	{
		public static DrivenTransformProperties GetDrivenProperties( RectTransform self )
		{
			var type             = typeof( RectTransform );
			var propertyInfo     = type.GetProperty( "drivenProperties", BindingFlags.Instance | BindingFlags.NonPublic );
			var drivenProperties = ( DrivenTransformProperties ) propertyInfo.GetValue( self );

			return drivenProperties;
		}
	}
}