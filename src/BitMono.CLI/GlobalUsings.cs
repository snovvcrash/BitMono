﻿global using Autofac;
global using BitMono.API.Protecting;
global using BitMono.API.Protecting.Resolvers;
global using BitMono.CLI.Modules;
global using BitMono.Core.Protecting.Resolvers;
global using BitMono.Host;
global using BitMono.Host.Modules;
global using BitMono.Obfuscation;
global using BitMono.Obfuscation.API;
global using NullGuard;
global using Serilog;
global using System;
global using System.Collections.Generic;
global using System.Diagnostics;
global using System.IO;
global using System.Linq;
global using System.Reflection;
global using System.Threading;
global using System.Threading.Tasks;
global using BitMono.Shared.Models;
global using Microsoft.Extensions.Options;
global using ILogger = Serilog.ILogger;