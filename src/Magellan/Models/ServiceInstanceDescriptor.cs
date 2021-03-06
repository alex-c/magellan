﻿using Consul;

namespace Magellan.Models
{
    /// <summary>
    /// Describes a service instance.
    /// </summary>
    public class ServiceInstanceDescriptor
    {
        /// <summary>
        /// Identifies the service of the described instance.
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// ID of the described service instance in Consul.
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Host of the described service instance.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port of the described service instance.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Initializes a descriptor from a Consul.NET agent service.
        /// </summary>
        /// <param name="service"></param>
        public ServiceInstanceDescriptor(AgentService service)
        {
            Service = service.Service;
            InstanceId = service.ID;
            Host = service.Address;
            Port = service.Port;
        }
    }
}
