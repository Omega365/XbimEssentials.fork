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
	public partial class @IfcElementAssembly : IIfcElementAssembly
	{

		[CrossSchemaAttribute(typeof(IIfcElementAssembly), 9)]
		Ifc4.Interfaces.IfcAssemblyPlaceEnum? IIfcElementAssembly.AssemblyPlace 
		{ 
			get
			{
				//## Custom code to handle enumeration of AssemblyPlace
				//##
				switch (AssemblyPlace)
				{
					case IfcAssemblyPlaceEnum.FACTORY:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY;
					case IfcAssemblyPlaceEnum.SITE:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE;
					case IfcAssemblyPlaceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of AssemblyPlace
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE:
						AssemblyPlace = IfcAssemblyPlaceEnum.SITE;
						return;
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY:
						AssemblyPlace = IfcAssemblyPlaceEnum.FACTORY;
						return;
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED:
						AssemblyPlace = IfcAssemblyPlaceEnum.NOTDEFINED;
						return;
					
					case null:
						AssemblyPlace = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcElementAssembly), 10)]
		Ifc4.Interfaces.IfcElementAssemblyTypeEnum? IIfcElementAssembly.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElementAssemblyTypeEnum.ABUTMENT:
						//## Handle translation of ABUTMENT member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of ABUTMENT member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY;
					case IfcElementAssemblyTypeEnum.ARCH:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ARCH;
					case IfcElementAssemblyTypeEnum.BEAM_GRID:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BEAM_GRID;
					case IfcElementAssemblyTypeEnum.BRACED_FRAME:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BRACED_FRAME;
					case IfcElementAssemblyTypeEnum.CROSS_BRACING:
						//## Handle translation of CROSS_BRACING member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of CROSS_BRACING member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.DECK:
						//## Handle translation of DECK member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of DECK member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.DILATATIONPANEL:
						//## Handle translation of DILATATIONPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of DILATATIONPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.ENTRANCEWORKS:
						//## Handle translation of ENTRANCEWORKS member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of ENTRANCEWORKS member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.GIRDER:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.GIRDER;
					case IfcElementAssemblyTypeEnum.GRID:
						//## Handle translation of GRID member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of GRID member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.MAST:
						//## Handle translation of MAST member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of MAST member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.PIER:
						//## Handle translation of PIER member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of PIER member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.PYLON:
						//## Handle translation of PYLON member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of PYLON member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.RAIL_MECHANICAL_EQUIPMENT_ASSEMBLY:
						//## Handle translation of RAIL_MECHANICAL_EQUIPMENT_ASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of RAIL_MECHANICAL_EQUIPMENT_ASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT;
					case IfcElementAssemblyTypeEnum.RIGID_FRAME:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.RIGID_FRAME;
					case IfcElementAssemblyTypeEnum.SHELTER:
						//## Handle translation of SHELTER member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of SHELTER member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.SIGNALASSEMBLY:
						//## Handle translation of SIGNALASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of SIGNALASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.SLAB_FIELD:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.SLAB_FIELD;
					case IfcElementAssemblyTypeEnum.SUMPBUSTER:
						//## Handle translation of SUMPBUSTER member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of SUMPBUSTER member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.SUPPORTINGASSEMBLY:
						//## Handle translation of SUPPORTINGASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of SUPPORTINGASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.SUSPENSIONASSEMBLY:
						//## Handle translation of SUSPENSIONASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of SUSPENSIONASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.TRACKPANEL:
						//## Handle translation of TRACKPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of TRACKPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.TRACTION_SWITCHING_ASSEMBLY:
						//## Handle translation of TRACTION_SWITCHING_ASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of TRACTION_SWITCHING_ASSEMBLY member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.TRAFFIC_CALMING_DEVICE:
						//## Handle translation of TRAFFIC_CALMING_DEVICE member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of TRAFFIC_CALMING_DEVICE member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.TRUSS:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.TRUSS;
					case IfcElementAssemblyTypeEnum.TURNOUTPANEL:
						//## Handle translation of TURNOUTPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						//TODO: Handle translation of TURNOUTPANEL member from IfcElementAssemblyTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElementAssemblyTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.USERDEFINED;
					case IfcElementAssemblyTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY:
						PredefinedType = IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ARCH:
						PredefinedType = IfcElementAssemblyTypeEnum.ARCH;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BEAM_GRID:
						PredefinedType = IfcElementAssemblyTypeEnum.BEAM_GRID;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BRACED_FRAME:
						PredefinedType = IfcElementAssemblyTypeEnum.BRACED_FRAME;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.GIRDER:
						PredefinedType = IfcElementAssemblyTypeEnum.GIRDER;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT:
						PredefinedType = IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.RIGID_FRAME:
						PredefinedType = IfcElementAssemblyTypeEnum.RIGID_FRAME;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.SLAB_FIELD:
						PredefinedType = IfcElementAssemblyTypeEnum.SLAB_FIELD;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.TRUSS:
						PredefinedType = IfcElementAssemblyTypeEnum.TRUSS;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.USERDEFINED:
						PredefinedType = IfcElementAssemblyTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElementAssemblyTypeEnum.NOTDEFINED:
						PredefinedType = IfcElementAssemblyTypeEnum.NOTDEFINED;
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