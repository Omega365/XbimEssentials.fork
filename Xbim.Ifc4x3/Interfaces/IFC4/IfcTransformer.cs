// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcTransformer : IIfcTransformer
	{

		[CrossSchemaAttribute(typeof(IIfcTransformer), 9)]
		Ifc4.Interfaces.IfcTransformerTypeEnum? IIfcTransformer.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcTransformerTypeEnum.CHOPPER:
						//## Handle translation of CHOPPER member from IfcTransformerTypeEnum in property PredefinedType
						//TODO: Handle translation of CHOPPER member from IfcTransformerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcTransformerTypeEnum.COMBINED:
						//## Handle translation of COMBINED member from IfcTransformerTypeEnum in property PredefinedType
						//TODO: Handle translation of COMBINED member from IfcTransformerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcTransformerTypeEnum.CURRENT:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.CURRENT;
					case IfcTransformerTypeEnum.FREQUENCY:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.FREQUENCY;
					case IfcTransformerTypeEnum.INVERTER:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.INVERTER;
					case IfcTransformerTypeEnum.RECTIFIER:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.RECTIFIER;
					case IfcTransformerTypeEnum.VOLTAGE:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.VOLTAGE;
					case IfcTransformerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcTransformerTypeEnum.USERDEFINED;
					case IfcTransformerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTransformerTypeEnum.CURRENT:
						PredefinedType = IfcTransformerTypeEnum.CURRENT;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.FREQUENCY:
						PredefinedType = IfcTransformerTypeEnum.FREQUENCY;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.INVERTER:
						PredefinedType = IfcTransformerTypeEnum.INVERTER;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.RECTIFIER:
						PredefinedType = IfcTransformerTypeEnum.RECTIFIER;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.VOLTAGE:
						PredefinedType = IfcTransformerTypeEnum.VOLTAGE;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.USERDEFINED:
						PredefinedType = IfcTransformerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcTransformerTypeEnum.NOTDEFINED:
						PredefinedType = IfcTransformerTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}