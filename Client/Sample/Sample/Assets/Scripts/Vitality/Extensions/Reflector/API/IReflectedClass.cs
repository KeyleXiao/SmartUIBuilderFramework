﻿//
//    Copyright 2016 KeyleXiao.
//    Project Site : http://keylexiao.github.io/SmartUIBuilderFramework
//    Contact to Me : Keyle_xiao@hotmail.com 
//
//   	Licensed under the Apache License, Version 2.0 (the "License");
//   	you may not use this file except in compliance with the License.
//   	You may obtain a copy of the License at
//
//   		http://www.apache.org/licenses/LICENSE-2.0
//
//   		Unless required by applicable law or agreed to in writing, software
//   		distributed under the License is distributed on an "AS IS" BASIS,
//   		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   		See the License for the specific language governing permissions and
//   		limitations under the License.
//this code from strangeico framework 
using System;
using System.Reflection;
using System.Collections.Generic;

namespace Vitality.Extensions
{
	public interface IReflectedClass
	{
		/// Get/set the preferred constructor
		ConstructorInfo Constructor{ get; set; }

		/// Get/set the preferred constructor's list of parameters
		Type[] ConstructorParameters{ get; set; }

		/// Get/set any PostConstructors. This includes inherited PostConstructors.
		MethodInfo[] PostConstructors{ get; set; }

		/// Get/set the list of setter injections. This includes inherited setters.
		KeyValuePair<Type, PropertyInfo>[] Setters{ get; set; }

		object[] SetterNames{ get; set; }

		/// For testing. Allows a unit test to assert whether the binding was
		/// generated on the current call, or on a prior one.
		bool PreGenerated{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		ConstructorInfo constructor{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		Type[] constructorParameters{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		MethodInfo[] postConstructors{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		KeyValuePair<Type, PropertyInfo>[] setters{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		object[] setterNames{ get; set; }

		/// [Obsolete"Strange migration to conform to C# guidelines. Removing camelCased publics"]
		bool preGenerated{ get; set; }
	}
}
