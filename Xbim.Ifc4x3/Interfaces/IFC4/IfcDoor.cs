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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcDoor : IIfcDoor
	{

		[CrossSchemaAttribute(typeof(IIfcDoor), 9)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoor.OverallHeight 
		{ 
			get
			{
				if (!OverallHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallHeight.Value);
			} 
			set
			{
				OverallHeight = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoor), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoor.OverallWidth 
		{ 
			get
			{
				if (!OverallWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallWidth.Value);
			} 
			set
			{
				OverallWidth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoor), 11)]
		Ifc4.Interfaces.IfcDoorTypeEnum? IIfcDoor.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcDoorTypeEnum.BOOM_BARRIER:
						//## Handle translation of BOOM_BARRIER member from IfcDoorTypeEnum in property PredefinedType
						//TODO: Handle translation of BOOM_BARRIER member from IfcDoorTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeEnum.DOOR:
						return Ifc4.Interfaces.IfcDoorTypeEnum.DOOR;
					case IfcDoorTypeEnum.GATE:
						return Ifc4.Interfaces.IfcDoorTypeEnum.GATE;
					case IfcDoorTypeEnum.TRAPDOOR:
						return Ifc4.Interfaces.IfcDoorTypeEnum.TRAPDOOR;
					case IfcDoorTypeEnum.TURNSTILE:
						//## Handle translation of TURNSTILE member from IfcDoorTypeEnum in property PredefinedType
						//TODO: Handle translation of TURNSTILE member from IfcDoorTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDoorTypeEnum.USERDEFINED;
					case IfcDoorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcDoorTypeEnum.DOOR:
						PredefinedType = IfcDoorTypeEnum.DOOR;
						return;
					case Ifc4.Interfaces.IfcDoorTypeEnum.GATE:
						PredefinedType = IfcDoorTypeEnum.GATE;
						return;
					case Ifc4.Interfaces.IfcDoorTypeEnum.TRAPDOOR:
						PredefinedType = IfcDoorTypeEnum.TRAPDOOR;
						return;
					case Ifc4.Interfaces.IfcDoorTypeEnum.USERDEFINED:
						PredefinedType = IfcDoorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDoorTypeEnum.NOTDEFINED:
						PredefinedType = IfcDoorTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoor), 12)]
		Ifc4.Interfaces.IfcDoorTypeOperationEnum? IIfcDoor.OperationType 
		{ 
			get
			{
				//## Custom code to handle enumeration of OperationType
				//##
				switch (OperationType)
				{
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_DOUBLE_SWING:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_DOUBLE_SWING;
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_FOLDING:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_FOLDING;
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_LIFTING_VERTICAL:
						//## Handle translation of DOUBLE_DOOR_LIFTING_VERTICAL member from IfcDoorTypeOperationEnum in property OperationType
						//TODO: Handle translation of DOUBLE_DOOR_LIFTING_VERTICAL member from IfcDoorTypeOperationEnum in property OperationType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING;
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT;
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT;
					case IfcDoorTypeOperationEnum.DOUBLE_DOOR_SLIDING:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SLIDING;
					case IfcDoorTypeOperationEnum.DOUBLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_SWING_LEFT;
					case IfcDoorTypeOperationEnum.DOUBLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_SWING_RIGHT;
					case IfcDoorTypeOperationEnum.FOLDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.FOLDING_TO_LEFT;
					case IfcDoorTypeOperationEnum.FOLDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.FOLDING_TO_RIGHT;
					case IfcDoorTypeOperationEnum.LIFTING_HORIZONTAL:
						//## Handle translation of LIFTING_HORIZONTAL member from IfcDoorTypeOperationEnum in property OperationType
						//TODO: Handle translation of LIFTING_HORIZONTAL member from IfcDoorTypeOperationEnum in property OperationType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeOperationEnum.LIFTING_VERTICAL_LEFT:
						//## Handle translation of LIFTING_VERTICAL_LEFT member from IfcDoorTypeOperationEnum in property OperationType
						//TODO: Handle translation of LIFTING_VERTICAL_LEFT member from IfcDoorTypeOperationEnum in property OperationType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeOperationEnum.LIFTING_VERTICAL_RIGHT:
						//## Handle translation of LIFTING_VERTICAL_RIGHT member from IfcDoorTypeOperationEnum in property OperationType
						//TODO: Handle translation of LIFTING_VERTICAL_RIGHT member from IfcDoorTypeOperationEnum in property OperationType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeOperationEnum.REVOLVING:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.REVOLVING;
					case IfcDoorTypeOperationEnum.REVOLVING_VERTICAL:
						//## Handle translation of REVOLVING_VERTICAL member from IfcDoorTypeOperationEnum in property OperationType
						//TODO: Handle translation of REVOLVING_VERTICAL member from IfcDoorTypeOperationEnum in property OperationType
						throw new System.NotImplementedException();
						//##
					case IfcDoorTypeOperationEnum.ROLLINGUP:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.ROLLINGUP;
					case IfcDoorTypeOperationEnum.SINGLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SINGLE_SWING_LEFT;
					case IfcDoorTypeOperationEnum.SINGLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SINGLE_SWING_RIGHT;
					case IfcDoorTypeOperationEnum.SLIDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SLIDING_TO_LEFT;
					case IfcDoorTypeOperationEnum.SLIDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SLIDING_TO_RIGHT;
					case IfcDoorTypeOperationEnum.SWING_FIXED_LEFT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SWING_FIXED_LEFT;
					case IfcDoorTypeOperationEnum.SWING_FIXED_RIGHT:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.SWING_FIXED_RIGHT;
					case IfcDoorTypeOperationEnum.USERDEFINED:
						//## Optional custom handling of OperationType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.USERDEFINED;
					case IfcDoorTypeOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorTypeOperationEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of OperationType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SINGLE_SWING_LEFT:
						OperationType = IfcDoorTypeOperationEnum.SINGLE_SWING_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SINGLE_SWING_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.SINGLE_SWING_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_SWING_LEFT:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_SWING_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_SWING_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_SWING_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_DOUBLE_SWING:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_DOUBLE_SWING;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SLIDING_TO_LEFT:
						OperationType = IfcDoorTypeOperationEnum.SLIDING_TO_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SLIDING_TO_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.SLIDING_TO_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_SLIDING:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_SLIDING;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.FOLDING_TO_LEFT:
						OperationType = IfcDoorTypeOperationEnum.FOLDING_TO_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.FOLDING_TO_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.FOLDING_TO_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.DOUBLE_DOOR_FOLDING:
						OperationType = IfcDoorTypeOperationEnum.DOUBLE_DOOR_FOLDING;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.REVOLVING:
						OperationType = IfcDoorTypeOperationEnum.REVOLVING;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.ROLLINGUP:
						OperationType = IfcDoorTypeOperationEnum.ROLLINGUP;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SWING_FIXED_LEFT:
						OperationType = IfcDoorTypeOperationEnum.SWING_FIXED_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.SWING_FIXED_RIGHT:
						OperationType = IfcDoorTypeOperationEnum.SWING_FIXED_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.USERDEFINED:
						OperationType = IfcDoorTypeOperationEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDoorTypeOperationEnum.NOTDEFINED:
						OperationType = IfcDoorTypeOperationEnum.NOTDEFINED;
						return;
					
					case null:
						OperationType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoor), 13)]
		Ifc4.MeasureResource.IfcLabel? IIfcDoor.UserDefinedOperationType 
		{ 
			get
			{
				if (!UserDefinedOperationType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedOperationType.Value);
			} 
			set
			{
				UserDefinedOperationType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}