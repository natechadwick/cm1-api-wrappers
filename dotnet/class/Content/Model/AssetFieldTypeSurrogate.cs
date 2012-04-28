//using System;
//using System.Runtime.Serialization;
//using System.Collections.Generic;
//
//namespace Percussion.CM1.API.Content.Model
//{
//	/// <summary>
//	/// A type surrogate substitutes object[] for Field when serializing/deserializing.
//	/// </summary>
//class AssetFieldTypeSurrogate : IDataContractSurrogate
//{
//    public Type GetDataContractType(Type type)
//    {
//        // "field" will be serialized as an object array
//        // This method is called during serialization, deserialization, and schema export. 
//        if (typeof(AssetFieldEntry).IsAssignableFrom(type))
//        {
//            return typeof(object[]);
//        }
//        return type;
//    }
//    public object GetObjectToSerialize(object obj, Type targetType)
//    {
//        // This method is called on serialization.
//        if (obj is AssetFieldEntry)
//        {
//            AssetFieldEntry field = (AssetFieldEntry) obj;
//            return new object[] { field.Name, field.Value };
//        }
//        return obj;
//    }
//    public object GetDeserializedObject(object obj, Type targetType)
//    {
//        // This method is called on deserialization.
//        if (obj is object[])
//        {
//            object[] arr = (object[])obj;
//            AssetFieldEntry field = new AssetFieldEntry { Name = (string)arr[0], Value = (string)arr[1] };
//            return field;
//        }
//        return obj;
//    }
//    public Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData)
//    {
//        return null; // not used
//    }
//    public System.CodeDom.CodeTypeDeclaration ProcessImportedType(System.CodeDom.CodeTypeDeclaration typeDeclaration, System.CodeDom.CodeCompileUnit compileUnit)
//    {
//        return typeDeclaration; // Not used
//    }
//    public object GetCustomDataToExport(Type clrType, Type dataContractType)
//    {
//        return null; // not used
//    }
//    public object GetCustomDataToExport(System.Reflection.MemberInfo memberInfo, Type dataContractType)
//    {
//        return null; // not used
//    }
//    public void GetKnownCustomDataTypes(Collection<Type> customDataTypes)
//    {
//        return; // not used
//    }
//  }
//}