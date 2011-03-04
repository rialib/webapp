//-----------------------------------------------------------------------
// <copyright file="CustomApplication.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Web
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Defines the methods that simplify service location and dependency resolution.
    /// </summary>
    public class CustomDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDependencyResolver"/> class.
        /// </summary>
        /// <param name="container">The Unity container.</param>
        public CustomDependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }

        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <param name="serviceType">The type of the requested service or object.</param>
        /// <returns>The requested service or object.</returns>
        public object GetService(Type serviceType)
        {
            return (serviceType.IsClass && !serviceType.IsAbstract) || container.IsRegistered(serviceType) ?
                container.Resolve(serviceType) : null;
        }

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <param name="serviceType">The type of the requested services.</param>
        /// <returns>The requested services.</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return (serviceType.IsClass && !serviceType.IsAbstract) || container.IsRegistered(serviceType) ?
                container.ResolveAll(serviceType) : new object[] { };
        }
    }
}
