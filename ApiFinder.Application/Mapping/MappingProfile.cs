﻿using AutoMapper;
using System.Reflection;

namespace ApiFinder.Application.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes().Where(
                    p => p.GetInterfaces().Any(i =>
                        i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            types.ForEach(
                t =>
                    {
                        var instance = Activator.CreateInstance(t);
                        var method = t.GetMethod("Mapping");
                        method?.Invoke(instance, new object[] { this });
                    });
        }
    }
}
