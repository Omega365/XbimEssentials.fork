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
	public partial class @IfcCableSegment : IIfcCableSegment
	{

		[CrossSchemaAttribute(typeof(IIfcCableSegment), 9)]
		Ifc4.Interfaces.IfcCableSegmentTypeEnum? IIfcCableSegment.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCableSegmentTypeEnum.BUSBARSEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.BUSBARSEGMENT;
					case IfcCableSegmentTypeEnum.CABLESEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.CABLESEGMENT;
					case IfcCableSegmentTypeEnum.CONDUCTORSEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.CONDUCTORSEGMENT;
					case IfcCableSegmentTypeEnum.CONTACTWIRESEGMENT:
						//## Handle translation of CONTACTWIRESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of CONTACTWIRESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.CORESEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.CORESEGMENT;
					case IfcCableSegmentTypeEnum.FIBERSEGMENT:
						//## Handle translation of FIBERSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of FIBERSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.FIBERTUBE:
						//## Handle translation of FIBERTUBE member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of FIBERTUBE member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.OPTICALCABLESEGMENT:
						//## Handle translation of OPTICALCABLESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of OPTICALCABLESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.STITCHWIRE:
						//## Handle translation of STITCHWIRE member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of STITCHWIRE member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.WIREPAIRSEGMENT:
						//## Handle translation of WIREPAIRSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of WIREPAIRSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableSegmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.USERDEFINED;
					case IfcCableSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.BUSBARSEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.BUSBARSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CABLESEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.CABLESEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CONDUCTORSEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.CONDUCTORSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CORESEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.CORESEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.USERDEFINED:
						PredefinedType = IfcCableSegmentTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcCableSegmentTypeEnum.NOTDEFINED;
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