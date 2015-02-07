// ***
// Do not edit this file. It has been generated by the ClassDynamizer tool.
// ***
#pragma warning disable 0108
using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PHP.Core;
using PHP.Core.Reflection;
namespace PHP.Library.Xml
{
	[Serializable()]
	public partial class XSLTProcessor : PhpObject
	{
		protected XSLTProcessor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public XSLTProcessor(ScriptContext context, bool newInstance) : base(context, newInstance)
		{
			if (mvpXmlAvailable)

				{
					
					object transform = Activator.CreateInstance(mvpXmlType);
					Load = (LoadDelegate)Delegate.CreateDelegate(typeof(LoadDelegate), transform, loadMethodMvp);
					GetOutputSettings = (GetOutputSettingsDelegate)Delegate.CreateDelegate(typeof(GetOutputSettingsDelegate), transform, getOutputSettingsMethodMvp);
					TransformToWriter = (TransformToWriterDelegate)Delegate.CreateDelegate(typeof(TransformToWriterDelegate), transform, transformToWriterMethodMvp);
					TransformToStream = (TransformToStreamDelegate)Delegate.CreateDelegate(typeof(TransformToStreamDelegate), transform, transformToStreamMethodMvp);
				}
			else

				{
					
					XslCompiledTransform transform = new XslCompiledTransform();
					Load = new LoadDelegate(transform.Load);
					GetOutputSettings = (GetOutputSettingsDelegate)Delegate.CreateDelegate(typeof(GetOutputSettingsDelegate), transform, getOutputSettingsMethodFW);
					TransformToWriter = new TransformToWriterDelegate(transform.Transform);
					TransformToStream = new TransformToStreamDelegate(transform.Transform);
				}
			this.xsltArgumentList = new XsltArgumentList();
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public XSLTProcessor(ScriptContext context, DTypeDesc caller) : this(context, true)
		{
			this.InvokeConstructor(context, caller);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object importStylesheet(ScriptContext __context, object doc)
		{
			
			DOMDocument tmp1 = doc as DOMDocument;
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(doc, "DOMDocument", "importStylesheet");
					return null;
				}
			return importStylesheet(tmp1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object importStylesheet(object instance, PhpStack stack)
		{
			stack.CalleeName = "importStylesheet";
			
			object arg1 = stack.PeekValue(1);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).importStylesheet(stack.Context, arg1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object transformToDoc(ScriptContext __context, object node)
		{
			
			IXmlDomNode tmp1 = node as IXmlDomNode;
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(node, "IXmlDomNode", "transformToDoc");
					return null;
				}
			return transformToDoc(tmp1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object transformToDoc(object instance, PhpStack stack)
		{
			stack.CalleeName = "transformToDoc";
			
			object arg1 = stack.PeekValue(1);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).transformToDoc(stack.Context, arg1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object transformToUri(ScriptContext __context, object doc, object uri)
		{
			
			DOMDocument tmp1 = doc as DOMDocument;
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(doc, "DOMDocument", "transformToUri");
					return null;
				}
			
			string tmp2 = PhpVariable.AsString(uri);
			if (tmp2 == null)

				{
					PhpException.InvalidImplicitCast(uri, "string", "transformToUri");
					return null;
				}
			return transformToUri(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object transformToUri(object instance, PhpStack stack)
		{
			stack.CalleeName = "transformToUri";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValue(2);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).transformToUri(stack.Context, arg1, arg2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object transformToXml(ScriptContext __context, object doc)
		{
			
			DOMDocument tmp1 = doc as DOMDocument;
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(doc, "DOMDocument", "transformToXml");
					return null;
				}
			return transformToXml(tmp1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object transformToXml(object instance, PhpStack stack)
		{
			stack.CalleeName = "transformToXml";
			
			object arg1 = stack.PeekValue(1);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).transformToXml(stack.Context, arg1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object setParameter(ScriptContext __context, object ns, object name, 		[System.Runtime.InteropServices.OptionalAttribute()]
object value)
		{
			
			string tmp1 = PhpVariable.AsString(ns);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(ns, "string", "setParameter");
					return null;
				}
			
			string tmp3 = null;
			if (value != Arg.Default)

				{
					tmp3 = PhpVariable.AsString(value);
					if (tmp3 == null)

						{
							PhpException.InvalidImplicitCast(value, "string", "setParameter");
							return null;
						}
				}
			return setParameter(tmp1, name, tmp3);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object setParameter(object instance, PhpStack stack)
		{
			stack.CalleeName = "setParameter";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValue(2);
			
			object arg3 = stack.PeekValueOptional(3);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).setParameter(stack.Context, arg1, arg2, arg3);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object getParameter(ScriptContext __context, object ns, object name)
		{
			
			string tmp1 = PhpVariable.AsString(ns);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(ns, "string", "getParameter");
					return null;
				}
			
			string tmp2 = PhpVariable.AsString(name);
			if (tmp2 == null)

				{
					PhpException.InvalidImplicitCast(name, "string", "getParameter");
					return null;
				}
			return getParameter(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object getParameter(object instance, PhpStack stack)
		{
			stack.CalleeName = "getParameter";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValue(2);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).getParameter(stack.Context, arg1, arg2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object removeParameter(ScriptContext __context, object ns, object name)
		{
			
			string tmp1 = PhpVariable.AsString(ns);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(ns, "string", "removeParameter");
					return null;
				}
			
			string tmp2 = PhpVariable.AsString(name);
			if (tmp2 == null)

				{
					PhpException.InvalidImplicitCast(name, "string", "removeParameter");
					return null;
				}
			return removeParameter(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object removeParameter(object instance, PhpStack stack)
		{
			stack.CalleeName = "removeParameter";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValue(2);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).removeParameter(stack.Context, arg1, arg2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object hasExsltSupport(ScriptContext __context)
		{
			return hasExsltSupport();
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object hasExsltSupport(object instance, PhpStack stack)
		{
			stack.CalleeName = "hasExsltSupport";
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).hasExsltSupport(stack.Context);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object registerPHPFunctions(ScriptContext __context, 		[System.Runtime.InteropServices.OptionalAttribute()]
object restrict)
		{
			registerPHPFunctions(restrict);
			return null;
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object registerPHPFunctions(object instance, PhpStack stack)
		{
			stack.CalleeName = "registerPHPFunctions";
			
			object arg1 = stack.PeekValueOptional(1);
			stack.RemoveFrame();
			return ((XSLTProcessor)instance).registerPHPFunctions(stack.Context, arg1);
		}
		private static void __PopulateTypeDesc(PhpTypeDesc desc)
		{
			desc.AddMethod("importStylesheet", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.importStylesheet));
			desc.AddMethod("transformToDoc", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.transformToDoc));
			desc.AddMethod("transformToUri", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.transformToUri));
			desc.AddMethod("transformToXml", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.transformToXml));
			desc.AddMethod("setParameter", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.setParameter));
			desc.AddMethod("getParameter", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.getParameter));
			desc.AddMethod("removeParameter", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.removeParameter));
			desc.AddMethod("hasExsltSupport", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.hasExsltSupport));
			desc.AddMethod("registerPHPFunctions", PhpMemberAttributes.Public, new RoutineDelegate(XSLTProcessor.registerPHPFunctions));
		}
	}
}