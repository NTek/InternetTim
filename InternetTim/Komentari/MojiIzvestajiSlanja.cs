﻿System.Reflection.AmbiguousMatchException: Ambiguous match found.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at ns22.Class269.Class272.Resolve(IAssemblyReference assemblyReference, String localPath)
   at ns37.Class486.Class487.Resolve(IAssemblyReference assemblyReference, String localPath)
   at ns2.Class604.Load(IAssemblyReference assemblyReference, String localPath)
   at Reflector.CodeModel.Memory.AssemblyReference.Resolve()
   at ns4.Class520.Class521.Class522..ctor(ICollection namespaces, INamespace namespaceDeclaration)
   at ns4.Class520.Class521.WriteNamespace(INamespace value)
   at ns37.Class486.method_4(ITypeDeclaration typeDeclaration, String sourceFile, ILanguageWriterConfiguration languageWriterConfiguration)
namespace InternetTim.Komentari
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;


