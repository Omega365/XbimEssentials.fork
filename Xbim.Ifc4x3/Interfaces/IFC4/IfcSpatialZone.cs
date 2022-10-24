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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcSpatialZone : IIfcSpatialZone
	{

		[CrossSchemaAttribute(typeof(IIfcSpatialZone), 9)]
		Ifc4.Interfaces.IfcSpatialZoneTypeEnum? IIfcSpatialZone.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSpatialZoneTypeEnum.CONSTRUCTION:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.CONSTRUCTION;
					case IfcSpatialZoneTypeEnum.FIRESAFETY:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.FIRESAFETY;
					case IfcSpatialZoneTypeEnum.INTERFERENCE:
						//## Handle translation of INTERFERENCE member from IfcSpatialZoneTypeEnum in property PredefinedType
						//TODO: Handle translation of INTERFERENCE member from IfcSpatialZoneTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSpatialZoneTypeEnum.LIGHTING:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.LIGHTING;
					case IfcSpatialZoneTypeEnum.OCCUPANCY:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.OCCUPANCY;
					case IfcSpatialZoneTypeEnum.RESERVATION:
						//## Handle translation of RESERVATION member from IfcSpatialZoneTypeEnum in property PredefinedType
						//TODO: Handle translation of RESERVATION member from IfcSpatialZoneTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSpatialZoneTypeEnum.SECURITY:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.SECURITY;
					case IfcSpatialZoneTypeEnum.THERMAL:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.THERMAL;
					case IfcSpatialZoneTypeEnum.TRANSPORT:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.TRANSPORT;
					case IfcSpatialZoneTypeEnum.VENTILATION:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.VENTILATION;
					case IfcSpatialZoneTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.USERDEFINED;
					case IfcSpatialZoneTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSpatialZoneTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.CONSTRUCTION:
						PredefinedType = IfcSpatialZoneTypeEnum.CONSTRUCTION;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.FIRESAFETY:
						PredefinedType = IfcSpatialZoneTypeEnum.FIRESAFETY;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.LIGHTING:
						PredefinedType = IfcSpatialZoneTypeEnum.LIGHTING;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.OCCUPANCY:
						PredefinedType = IfcSpatialZoneTypeEnum.OCCUPANCY;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.SECURITY:
						PredefinedType = IfcSpatialZoneTypeEnum.SECURITY;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.THERMAL:
						PredefinedType = IfcSpatialZoneTypeEnum.THERMAL;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.TRANSPORT:
						PredefinedType = IfcSpatialZoneTypeEnum.TRANSPORT;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.VENTILATION:
						PredefinedType = IfcSpatialZoneTypeEnum.VENTILATION;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.USERDEFINED:
						PredefinedType = IfcSpatialZoneTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSpatialZoneTypeEnum.NOTDEFINED:
						PredefinedType = IfcSpatialZoneTypeEnum.NOTDEFINED;
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