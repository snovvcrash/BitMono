﻿global using AsmResolver.DotNet;
global using AsmResolver.DotNet.Cloning;
global using AsmResolver.DotNet.Code.Cil;
global using AsmResolver.DotNet.Signatures;
global using AsmResolver.PE.DotNet.Cil;
global using BitMono.API.Protecting;
global using BitMono.API.Protecting.Contexts;
global using BitMono.API.Protecting.Injection;
global using BitMono.API.Protecting.Pipeline;
global using BitMono.API.Protecting.Renaming;
global using BitMono.Core.Protecting.Analyzing.DnlibDefs;
global using BitMono.Core.Protecting.Analyzing.TypeDefs;
global using BitMono.Runtime;
global using BitMono.Utilities.Extensions.AsmResolver;
global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Threading;
global using System.Threading.Tasks;
global using MethodAttributes = AsmResolver.PE.DotNet.Metadata.Tables.Rows.MethodAttributes;