﻿global using Autofac;
global using Autofac.Core;
global using Autofac.Extensions.DependencyInjection;
global using BitMono.API.Configuration;
global using BitMono.API.Ioc;
global using BitMono.API.Protecting;
global using BitMono.API.Protecting.Analyzing;
global using BitMono.API.Protecting.Pipeline;
global using BitMono.API.Protecting.Renaming;
global using BitMono.API.Protecting.Resolvers;
global using BitMono.Core.Protecting;
global using BitMono.Core.Protecting.Injection;
global using BitMono.Core.Protecting.Renaming;
global using BitMono.Core.Protecting.Resolvers;
global using BitMono.Host.Configurations;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Serilog;
global using Serilog.Events;
global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Reflection;
global using Module = Autofac.Module;