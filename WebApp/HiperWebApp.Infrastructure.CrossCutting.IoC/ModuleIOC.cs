﻿using Autofac;

namespace HiperWebApp.Infrastructure.CrossCutting.IoC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC.Load(builder);

            #endregion
        }
    }
}
